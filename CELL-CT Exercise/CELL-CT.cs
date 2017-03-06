using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CELL_CT_Exercise
{
    public partial class CELL_CT : Form
    {
        
        private string[] pictures;           //Pictures loaded from a folder
        private int PictureIndex = 0;       //Picture index
        private int nextImage;
        private int LastAvailableImage;
        private Img[] Images;
        private Bitmap OriginalImage;

        public CELL_CT()
        {
            InitializeComponent();
        }

       


        private void openButton_Click(object sender, EventArgs e)
        {
 
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "JPEG|*.jpg|Bitmaps|*.bmp";

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictures = openFileDialog.FileNames;

                    //Initializing array of Img and set image name
                    Images = new Img[pictures.Length];
                    string picture_dir = "";
                    for (int i = 0; i < pictures.Length; i++)
                    {
                        picture_dir = pictures[i];
                        Images[i] = new Img()
                        {
                            ImageName = picture_dir.Substring(picture_dir.LastIndexOf("\\") + 1)
                        };
                    }


                    ShowCurrentImage(0);

                    //Enable 'Sahrpening Enablement' checkbox only when at least
                    //ONE image is loaded
                    enableSharpening.Enabled = (pictures.Length > 0);


                    //Set Image Slide bar Enabled              
                    ImageSlide.Enabled = true;
                    

                    //Set min and max value of Image slide bar
                    ImageSlide.Minimum = 0;
                    ImageSlide.Maximum = pictures.Length - 1;

                    //Set both labels under Image slide bar
                    FirstPic.Text = "1";
                    LastPic.Text = pictures.Length.ToString();

                   
                }
            }

            catch (OutOfMemoryException OM)
            {
                var Result = MessageBox.Show("Can't display image" + Images[PictureIndex].ImageName +" , maybe the file corrupted, damages, or too large", "Indexing error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (ImageSlide.Maximum > 0)
                    ShowCurrentImage(LastAvailableImage - PictureIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in file(s) you have select :(","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void enableSharpening_Changed(object sender, EventArgs e)
        {
            SharpenButton.Enabled = 
            ResetImage.Enabled = (enableSharpening.CheckState == CheckState.Checked);
           
            //Set Image Sharpening Enablement value (true or false) into Img Array
            Images[PictureIndex].PicturesSharpEnabled = ImageSlide.Enabled;
        }
        private void ImageSlide_Scroll(object sender, EventArgs e)
        {
            //nextImage variable to determing wheather the trabckbar is indexing to left or right
            nextImage = (ImageSlide.Value - PictureIndex > 0) ? 1 : -1;


            ShowCurrentImage(nextImage);
            getSharpeningValues();
        }

        //Sharpening picture
        private void SharpenButton_Click(object sender, EventArgs e)
        {
            try
            {
                setShapeningLevel();

            }catch(Exception E)
            {
                MessageBox.Show("Error in setting sharpening level", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImageSizeOption_Checked(object sender, EventArgs e)
        {
            var selected = ((RadioButton)sender).Name;

            switch (selected)
            {
                case ("Normal"):
                    CellCTpictureBox.SizeMode = PictureBoxSizeMode.Normal;
                    break;

                case ("StretchImage"):
                    CellCTpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case ("CenterImage"):
                    CellCTpictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;

                case ("AutoSize"):
                    CellCTpictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case ("Zoom"):
                    CellCTpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                default:
                    CellCTpictureBox.SizeMode = PictureBoxSizeMode.Normal;
                    break;


            }



        }

        //Reset current sharpened Image to original view
        private void ResetImage_Click(object sender, EventArgs e)
        {
            try
            {
                CellCTpictureBox.Image = OriginalImage ?? Bitmap.FromFile(pictures[PictureIndex]);
            }
            catch (OutOfMemoryException OM)
            {
                 MessageBox.Show("There is no displayed image :(", "Indexing error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            
        }








        //Helpers

        protected void ShowCurrentImage(int nextIndex)
        {
            try
            {
                nextIndex += PictureIndex;
                //Making sure that PictureIndex value >= 0 and <= # of images
                PictureIndex = Math.Max(0, nextIndex);
                PictureIndex = Math.Min(PictureIndex, pictures.Length - 1);

                //Bellow commented code is for testing purpose,
                //throwing FileNotFoundException to check if the file was not found

                //if (PictureIndex == 0 || PictureIndex == 1)
                //{
                //    // nextImage = (ImageSlide.Value - PictureIndex > 0) ? nextImage + 1 : nextImage - 1;
                //    throw new FileNotFoundException();

                //}




                //Set PictureBox with current image index
                CellCTpictureBox.Image = Bitmap.FromFile(pictures[PictureIndex]);

                //Set ImageName in label
                ImageName.Text = Images[PictureIndex].ImageName ?? "Some Image";

                //Set Original Image value for Image reset purpose, if It does not exists, I can 
                OriginalImage = (Bitmap)CellCTpictureBox.Image.Clone();


                ImageSlide.Value = Math.Min(PictureIndex, pictures.Length - 1);
                ImageSlide.Value = Math.Max(0, ImageSlide.Value);
                LastAvailableImage = ImageSlide.Value;

            }
    
            catch (FileNotFoundException fnf)
            {

                var result = CustomMessageBox.Show("Image file " + Images[PictureIndex].ImageName + " Not found :(", "Error", "Current Image", "Cross Image");


                if (result.Equals("FirstButton"))
                    ShowCurrentImage(-nextImage);
                else if (result.Equals("SecondButton"))
                    ShowCurrentImage(nextImage);
                else
                    ShowCurrentImage(LastAvailableImage - PictureIndex);


            }

            catch (OutOfMemoryException fnf)
            {
                var result = CustomMessageBox.Show("Image file " + Images[PictureIndex].ImageName +
                 " can not be displayed :(, the file is appeared to be corrupted, destroyed, out too large. ", "Error", "Current Image", "Cross Image");


                if (result.Equals("FirstButton"))
                    ShowCurrentImage(-nextImage);
                else if (result.Equals("SecondButton"))
                    ShowCurrentImage(nextImage);
                else
                    ShowCurrentImage(LastAvailableImage - PictureIndex);

                //if (ImageSlide.Enabled)
                //{

                //}
                //else
                //{
                //    MessageBox.Show("Can't display image" + Images[PictureIndex].ImageName + " , maybe the file corrupted, damages, or too large", "Indexing error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //}


            }
            catch (ArgumentOutOfRangeException AOB)
            {
                MessageBox.Show("No More Images", "Indexing error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowCurrentImage(LastAvailableImage - PictureIndex);
            }

            catch (IndexOutOfRangeException IOB)
            {
                MessageBox.Show("No More Images", "Indexing error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowCurrentImage(LastAvailableImage - PictureIndex);
            }


           


        }

        protected void setShapeningLevel()
        {
            //Sharpening prcess
            

            Bitmap bmap = (Bitmap)CellCTpictureBox.Image.Clone();

            int width = bmap.Width;
            int height = bmap.Height;

            // Create sharpening filter (2D High Pass Filter).
            const int filterSize = 5;

            var filter = new double[,]
                {
                    {-1, -1, -1, -1, -1},
                    {-1,  2,  2,  2, -1},
                    {-1,  2, 16,  2, -1},
                    {-1,  2,  2,  2, -1},
                    {-1, -1, -1, -1, -1}
                };
            double strength = 0.5;
            double bias = 1.0 - strength;
            double factor = strength / 16.0;

            const int s = filterSize / 2;

            var result = new Color[bmap.Width, bmap.Height];

            // Lock image bits for read/write.
            if (bmap != null)
            {
                BitmapData pbits = bmap.LockBits(new Rectangle(0, 0, width, height),
                                                            ImageLockMode.ReadWrite,
                                                            PixelFormat.Format24bppRgb);

                // Declare an array to hold the bytes of the bitmap.
                int bytes = pbits.Stride * height;
                var rgbValues = new byte[bytes];

                // Copy the RGB values into the array.
                Marshal.Copy(pbits.Scan0, rgbValues, 0, bytes);

                int rgb;
                // Fill the color array with the new sharpened color values.
                for (int x = s; x < width - s; x++)
                {
                    for (int y = s; y < height - s; y++)
                    {
                        double red = 0.0, green = 0.0, blue = 0.0;

                        for (int filterX = 0; filterX < filterSize; filterX++)
                        {
                            for (int filterY = 0; filterY < filterSize; filterY++)
                            {
                                int imageX = (x - s + filterX + width) % width;
                                int imageY = (y - s + filterY + height) % height;

                                rgb = imageY * pbits.Stride + 3 * imageX;

                                red += rgbValues[rgb + 2] * filter[filterX, filterY];
                                green += rgbValues[rgb + 1] * filter[filterX, filterY];
                                blue += rgbValues[rgb + 0] * filter[filterX, filterY];
                            }

                            rgb = y * pbits.Stride + 3 * x;



                            int R = Math.Min(Math.Max((int)(factor * red + (bias * rgbValues[rgb + 2])), 0), 255);
                            int G = Math.Min(Math.Max((int)(factor * green + (bias * rgbValues[rgb + 1])), 0), 255);
                            int B = Math.Min(Math.Max((int)(factor * blue + (bias * rgbValues[rgb + 0])), 0), 255);

                            result[x, y] = Color.FromArgb(R, G, B);
                        }
                    }
                }

                // Update the image with the sharpened pixels.
                for (int x = s; x < width - s; x++)
                {
                    for (int y = s; y < height - s; y++)
                    {
                        rgb = y * pbits.Stride + 3 * x;

                        rgbValues[rgb + 2] = result[x, y].R;
                        rgbValues[rgb + 1] = result[x, y].G;
                        rgbValues[rgb + 0] = result[x, y].B;
                    }
                }

                // Copy the RGB values back to the bitmap.
                Marshal.Copy(rgbValues, 0, pbits.Scan0, bytes);
                // Release image bits.
                bmap.UnlockBits(pbits);
            }

 
              CellCTpictureBox.Image = bmap;
            //CellCTpictureBox.Image = sharpenImage;


            //Set sharpening level of current displayed image
            //PicturesSharpLevel[PictureIndex] = ImageSlide.Value;
        }
   
        //Set Sharpening Enablment for each image
        protected void getSharpeningValues()
        {
            //Setting sharpening enablement values from array of Img objects

            SharpenButton.Enabled =
            ResetImage.Enabled =
            enableSharpening.Checked = Images[PictureIndex].PicturesSharpEnabled;
        }

   
    }
}



public class Img
{
    public string ImageName { get; set; }
    public bool PicturesSharpEnabled { get; set; }

    public PictureBoxSizeMode SizeMode { get; set; }
}
