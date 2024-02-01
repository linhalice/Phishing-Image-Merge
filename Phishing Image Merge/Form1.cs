using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace Phishing_Image_Merge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxImagePath.Text = Settings1.Default.ImagePath;
            textBox1.Text = Settings1.Default.ButtonScale;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string folderPath = Settings1.Default.ImagePath;
            List<string> files = Directory.GetFiles(folderPath, "*.jpg").ToList();
            bool isMerge1 = checkBoxMerge1.Checked;
            bool isMerge2 = checkBoxMerge2.Checked;
            bool isPlayFacebook = checkBoxPlayFacebook.Checked;
            bool isPlaySelect = checkBoxPlaySelect.Checked;
            string playSelectPath = textBoxPlaySelect.Text;
            bool playSelectPathIsExist = File.Exists(playSelectPath);


            Thread thread = new Thread(() =>
            {
                if (isMerge1)
                {
                    for (int i = 0; i < 1000; i++)
                    {
                        var list = RandomSelect(files, 5);

                        AuraeMergeImages.MergeImages(list, "Merge1");
                    }
                }

                if (isMerge2)
                {
                    for (int i = 0; i < 1000; i++)
                    {
                        var list = RandomSelect(files, 5);

                        AuraeMergeImages.MergeImagesV2(list, "Merge2");
                    }
                }

                if (isPlayFacebook)
                {
                    foreach (string file in files)
                    {
                        AuraeMergeImages.MergeImageWithButton(file, "Button\\Facebook.png", "PlayFacebook");
                    }
                }

                if (isPlaySelect && playSelectPathIsExist)
                {
                    foreach (string file in files)
                    {
                        AuraeMergeImages.MergeImageWithButton(file, playSelectPath, "Play tuỳ chọn");
                    }
                }


                MessageBox.Show("Đã hoàn thành ghép ảnh!");
            });
            thread.IsBackground = true;
            thread.Start();
        }

        static List<string> RandomSelect(List<string> list, int numberOfItems)
        {
            Random rand = new Random();
            List<string> selectedItems = new List<string>();

            // Tạo một bản sao của list để tránh thay đổi list gốc
            List<string> tempList = new List<string>(list);

            for (int i = 0; i < numberOfItems; i++)
            {
                int randomIndex = rand.Next(tempList.Count);
                selectedItems.Add(tempList[randomIndex]);
                tempList.RemoveAt(randomIndex); // Loại bỏ phần tử đã chọn để tránh chọn lại
            }

            return selectedItems;
        }

        private void textBoxImagePath_TextChanged(object sender, EventArgs e)
        {
            Settings1.Default.ImagePath = textBoxImagePath.Text;
            Settings1.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "Button\\";
                openFileDialog.Filter = "Tất cả file (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn của file đã chọn
                    string filePath = openFileDialog.FileName;
                    textBoxPlaySelect.Text = filePath;
                    // Hiển thị đường dẫn file hoặc làm gì đó với file
                    MessageBox.Show($"Đã chọn Button: {filePath}", "Thông Tin Button", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void checkBoxPlaySelect_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Settings1.Default.ButtonScale = textBox1.Text;
            Settings1.Default.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Chọn Thư Mục";
                folderBrowserDialog.ShowNewFolderButton = true; // Cho phép tạo thư mục mới

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn của thư mục đã chọn
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;
                    textBoxImagePath.Text = selectedFolderPath;
                    MessageBox.Show($"Đường dẫn thư mục chứa ảnh: {selectedFolderPath}", "Thông Tin Thư Mục", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("cmd", $"/c start https://www.facebook.com/profile.php?id=100004500669669") { CreateNoWindow = true });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Không thể mở URL: {ex.Message}");
            }
        }
    
        private void button4_Click(object sender, EventArgs e)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Process.Start("explorer.exe", AppDomain.CurrentDomain.BaseDirectory);
            }
        }
    }
}
