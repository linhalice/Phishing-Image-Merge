using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phishing_Image_Merge
{
    public class AuraeMergeImages
    {
        public static void MergeImages(List<string> files, string outputFolderPath)
        {
            if (!Directory.Exists(outputFolderPath))
            {
                Directory.CreateDirectory(outputFolderPath);
            }

            int padding = 5; // Khoảng trắng giữa các ảnh
            int imageSizeTopRow = 500; // Kích thước của mỗi ảnh trên hàng đầu
            int imageSizeBottomRow = 330; // Kích thước của mỗi ảnh trên hàng thứ hai
            int width= 1005; // Chiều rộng tổng cộng, tính cả khoảng trắng

            int height = imageSizeTopRow + imageSizeBottomRow + padding;

            using (Bitmap finalImage = new Bitmap(width, height))
            {
                using (Graphics g = Graphics.FromImage(finalImage))
                {
                    g.Clear(Color.White); // Đặt nền trắng cho ảnh ghép

                    for (int i = 0; i < 5 && (i) < files.Count; i++)
                    {
                        using (Bitmap originalImage = new Bitmap(files[i]))
                        {
                            Bitmap processedImage;

                            if (i == 4) // Xử lý đặc biệt cho ảnh số 5
                            {
                                Bitmap croppedImage = CropToSquare(originalImage);
                                processedImage = ResizeImage(croppedImage, 500, 500);
                                DarkenImage(processedImage); // Làm tối ảnh trước khi thêm chữ
                                AddTextToImage(processedImage);
                            }
                            else
                            {
                                processedImage = CropToSquare(originalImage);
                            }

                            int x, y, imageSize;

                            if (i < 2) // Hàng đầu tiên
                            {
                                x = i * (imageSizeTopRow + padding);
                                y = 0;
                                imageSize = imageSizeTopRow;
                            }
                            else // Hàng thứ hai
                            {
                                x = (i - 2) * (imageSizeBottomRow + padding);
                                y = imageSizeTopRow + padding;
                                imageSize = imageSizeBottomRow;
                            }

                            g.DrawImage(processedImage, new Rectangle(x, y, imageSize, imageSize));
                        }
                    }
                }

                // Lưu ảnh ghép
                finalImage.Save(Path.Combine(outputFolderPath, $"{Guid.NewGuid().ToString()}.jpg"));
            }
        }

        public static void MergeImagesV2(List<string> files, string outputFolderPath)
        {
            if (!Directory.Exists(outputFolderPath))
            {
                Directory.CreateDirectory(outputFolderPath);
            }


            int padding = 5; // Khoảng trắng giữa các ảnh
            int imageSizeTopRow = 500; // Kích thước của mỗi ảnh lớn
            int imageSizeBottomRow = 330; // Kích thước của mỗi ảnh nhỏ

            // Tính toán chiều rộng và chiều cao dựa trên bố cục mới
            int width = imageSizeTopRow + padding + imageSizeBottomRow; // Chiều rộng cần cho cả hai cột
            int height = Math.Max(imageSizeTopRow, imageSizeBottomRow * 3 + padding * 2); // Chiều cao cần dựa trên cột cao nhất

            using (Bitmap finalImage = new Bitmap(width, height))
            {
                using (Graphics g = Graphics.FromImage(finalImage))
                {
                    g.Clear(Color.White); // Đặt nền trắng cho ảnh ghép

                    for (int i = 0; i < 5 && (i) < files.Count(); i++)
                    {
                        using (Bitmap originalImage = new Bitmap(files[i]))
                        {
                            Bitmap processedImage;

                            if (i < 2) // Ảnh lớn cho cột đầu tiên
                            {
                                processedImage = ResizeImage(CropToSquare(originalImage), imageSizeTopRow, imageSizeTopRow);
                            }
                            else // Ảnh nhỏ cho cột thứ hai
                            {
                                processedImage = ResizeImage(CropToSquare(originalImage), imageSizeBottomRow, imageSizeBottomRow);
                                if (i == 4) // Xử lý đặc biệt cho ảnh số 5
                                {
                                    DarkenImage(processedImage); // Làm tối ảnh trước khi thêm chữ
                                    AddTextToImage(processedImage);
                                }
                            }

                            int x, y;

                            if (i < 2) // Vị trí cho cột đầu tiên (ảnh to)
                            {
                                x = 0;
                                y = i * imageSizeTopRow + i * padding;
                            }
                            else // Vị trí cho cột thứ hai (ảnh nhỏ)
                            {
                                x = imageSizeTopRow + padding;
                                y = (i - 2) * (imageSizeBottomRow + padding);
                            }

                            g.DrawImage(processedImage, new Rectangle(x, y, processedImage.Width, processedImage.Height));
                        }
                    }
                }

                // Lưu ảnh ghép
                finalImage.Save(Path.Combine(outputFolderPath, $"{Guid.NewGuid().ToString()}.jpg"));
            }
        }




        public static void MergeImageWithButton(string imagePath, string buttonPath, string outputFolderPath)
        {
            if (!Directory.Exists(outputFolderPath))
            {
                Directory.CreateDirectory(outputFolderPath);
            }

            using (Image originalImage = Image.FromFile(imagePath))
            using (Image buttonImage = Image.FromFile(buttonPath))
            {
                // Crop ảnh về tỉ lệ 9x16
                Image croppedImage = CropToRatio(originalImage, 9, 16);

                int buttonNewHeight = croppedImage.Height / Int32.Parse(Settings1.Default.ButtonScale);
                int buttonNewWidth = (int)(buttonImage.Width / ((double)buttonImage.Height / buttonNewHeight));

                using (Bitmap resizedButtonImage = new Bitmap(buttonImage, buttonNewWidth, buttonNewHeight))
                using (Graphics g = Graphics.FromImage(croppedImage))
                {
                    // Tính toán vị trí để đặt nút button chính giữa ảnh
                    int x = (croppedImage.Width - resizedButtonImage.Width) / 2;
                    int y = (croppedImage.Height - resizedButtonImage.Height) / 2;

                    // Ghép button đã điều chỉnh kích thước vào ảnh
                    g.DrawImage(resizedButtonImage, new Point(x, y));
                }

                // Lưu ảnh mới
                string outputPath = Path.Combine(outputFolderPath, $"{Guid.NewGuid().ToString()}.jpg");
                croppedImage.Save(outputPath);
                Console.WriteLine($"Image saved to {outputPath}");
            }
        }

        static Image CropToRatio(Image image, int numerator, int denominator)
        {
            int originalWidth = image.Width;
            int originalHeight = image.Height;
            int newWidth, newHeight;

            if (originalWidth * numerator > originalHeight * denominator)
            {
                // Ảnh quá rộng
                newHeight = originalHeight;
                newWidth = originalHeight * denominator / numerator;
            }
            else
            {
                // Ảnh quá cao
                newWidth = originalWidth;
                newHeight = originalWidth * numerator / denominator;
            }

            int startX = (originalWidth - newWidth) / 2;
            int startY = (originalHeight - newHeight) / 2;

            Bitmap croppedBitmap = new Bitmap(newWidth, newHeight);

            using (Graphics g = Graphics.FromImage(croppedBitmap))
            {
                g.DrawImage(image, new Rectangle(0, 0, newWidth, newHeight), new Rectangle(startX, startY, newWidth, newHeight), GraphicsUnit.Pixel);
            }

            return croppedBitmap;
        }

        private static void DarkenImage(Bitmap image)
        {
            using (Graphics g = Graphics.FromImage(image))
            {
                Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
                using (Brush semiTransBrush = new SolidBrush(Color.FromArgb(128, 0, 0, 0)))
                {
                    g.FillRectangle(semiTransBrush, rect);
                }
            }
        }


        private static void AddTextToImage(Bitmap image)
        {
            using (Graphics g = Graphics.FromImage(image))
            {
                string text = "+" + new Random().Next(10, 31).ToString();
                using (Font font = new Font("Segoe UI", 60, FontStyle.Bold))
                {
                    SizeF textSize = g.MeasureString(text, font);
                    PointF location = new PointF((image.Width - textSize.Width) / 2, (image.Height - textSize.Height) / 2);

                    using (Brush whiteBrush = new SolidBrush(Color.White))
                    {
                        g.DrawString(text, font, whiteBrush, location);
                    }
                }
            }
        }

        private static Bitmap ResizeImage(Bitmap original, int width, int height)
        {
            Bitmap resized = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resized))
            {
                g.DrawImage(original, new Rectangle(0, 0, width, height));
            }
            return resized;
        }

        private static Bitmap CropToSquare(Bitmap original)
        {
            int size = Math.Min(original.Width, original.Height);
            int x = (original.Width - size) / 2;
            int y = (original.Height - size) / 2;

            return new Bitmap(original.Clone(new Rectangle(x, y, size, size), original.PixelFormat));
        }

    }
}
