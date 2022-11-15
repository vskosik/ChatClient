using HollywoodClient.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HollywoodClient
{
    public partial class Form1 : Form
    {
        string[] files = null;
        JsonSerializerOptions options;

        public Form1()
        {
            InitializeComponent();
            cbMovies.DisplayMember = "Title";
            cbMovies.ValueMember = "Id";
            options = new JsonSerializerOptions();
            options.PropertyNameCaseInsensitive = true;
            options.Converters.Add(new JsonStringEnumConverter());
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "jpg|*.jpg|png|*.png|gif|*.gif|tiff|*.tiff|bmp|*.bmp";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.FileNames;
                foreach (var file in files)
                {
                    createTab(file, new Bitmap(file));
                }
            }
        }

        private void createTab(string file, Bitmap bitmap)
        {
            var page = new TabPage();
            page.Text = Path.GetFileName(file);
            page.Dock = DockStyle.Fill;
            var pbox = new PictureBox();
            pbox.Image = bitmap;
            pbox.SizeMode = PictureBoxSizeMode.Zoom;
            pbox.Dock = DockStyle.Fill;
            page.Controls.Add(pbox);
            tabControl1.TabPages.Add(page);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var url = "http://localhost:37114/api/movies";
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseText = response.Content.ReadAsStringAsync().Result;
                    var list = JsonSerializer.Deserialize<List<Movie>>(responseText, options);
                    cbMovies.DataSource = list;
                }
            }
        }

        private async void btUload_Click(object sender, EventArgs e)
        {
            var url = "http://localhost:37114/api/images";
            foreach (var file in files)
            {
                await UploadImageAsync(file, url);
            }
        }

        private async Task UploadImageAsync(string file, string url)
        {
            var buff = File.ReadAllBytes(file);
            var b64 = Convert.ToBase64String(buff);
            var movieId = (int)cbMovies.SelectedValue;
            var mi = new MovieImage { MovieId = movieId, Picture = b64 };
            var miJson = JsonSerializer.Serialize(mi);
            var content = new StringContent(miJson, Encoding.UTF8, "application/json");
            using HttpClient client = new HttpClient();
            var result = await client.PostAsync(url, content);
        }

        private async void btDisplay_ClickAsync(object sender, EventArgs e)
        {
            string url = "http://localhost:37114/api/movies";
            int movieId = (int)(cbMovies.SelectedValue);
            using HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string responseText = await response.Content.ReadAsStringAsync();
                List<MovieImage> list = JsonSerializer.Deserialize<List<MovieImage>>(responseText, options);
                int count = 1;
                foreach (MovieImage item in list)
                {
                    if (item.MovieId != movieId) continue;
                    createTab("picture" + count++, Base64ToBitmap(item.Picture));
                }
            }
        }

        public static Bitmap Base64ToBitmap(string base64String)
        {
            Bitmap bmp = null;
            //Convert Base64 string to byte[]
            byte[] byteBuffer = Convert.FromBase64String(base64String);
            MemoryStream memoryStream = new MemoryStream(byteBuffer);

            memoryStream.Position = 0;

            bmp = (Bitmap)Bitmap.FromStream(memoryStream);

            memoryStream.Close();
            memoryStream = null;
            byteBuffer = null;

            return bmp;
        }
    }
}
