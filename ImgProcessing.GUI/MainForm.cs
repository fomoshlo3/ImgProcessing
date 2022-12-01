using ImgProcess;

namespace ImgProcessing.GUI
{
    public partial class MainForm : Form
    {
        private Bitmap? _BitmapImage;
        byte[]? _BitmapData;
        public MainForm()
        {
            InitializeComponent();
        }

        private void CmdLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new()
            {
                Filter = "Bild | *.jpg"
            };
            openFile.ShowDialog();

            _BitmapImage = new Bitmap(openFile.FileName);

            PictBxLoadedImage.Image = _BitmapImage;
            PictBxLoadedImage.SizeMode = PictureBoxSizeMode.StretchImage;
            LblImageInfo.Text = 
                $"Breite :{_BitmapImage.Width} px,\n" +
                $"Höhe : {_BitmapImage.Height} px\n" +
                $"BitmapArrayLength :\n" +
                $"\t{_BitmapImage.Height * _BitmapImage.Width * 3} Fields\n";
 
        }

        private void CmdConvertToGrayscale_Click(object sender, EventArgs e)
        {
            
            _BitmapData = BaseFunc.getImageArray(_BitmapImage);
            
            //TODO: Zuordnung der Faktoren zu Slidern mit default Einstellung 

            //int[] red = new int[_BitmapData.Length / 3];
            //int[] green = new int[red.Length];
            //int[] blue = new int[red.Length];

            byte[] grayscale = new byte[_BitmapData.Length];
            int count = 0;

            //Aufteilung und Umrechnung der einzelnen Kanäle in Graustufen mit Gewichtung menschlicher Wahrnehmung
            for (int i = 0; i < _BitmapData.Length; i += 3)
            {
                //red[count] = Convert.ToInt32(Math.Round(Convert.ToDecimal(_BitmapData[i]) * 0.299m, 0)); //Red: 0,299 × Rotanteil
                //green[count] = Convert.ToInt32(Math.Round(Convert.ToDecimal(_BitmapData[i + 1]) * 0.587m, 0)); //Green: 0,587 × Grünanteil
                //blue[count] = Convert.ToInt32(Math.Round(Convert.ToDecimal(_BitmapData[i + 2]) * 0.114m, 0)); //Blue: 0,114 × Blauanteil

                //Summierung der Anteiligen Werte
                grayscale[count] = grayscale[i + 1] = grayscale[i + 2] = (byte)(_BitmapData[i] * 0.29 + _BitmapData[i + 1] * 0.59 + _BitmapData[i + 2] * 0.11);
                //grayscale[count] = Convert.ToByte(red[count] + green[count] + blue[count]);
                count+=3;
            }

            //Instanzierung eines Bitmap Objekts in Grau 

            Bitmap bitmapGray = BaseFunc.calBitmap(grayscale, _BitmapImage.Width, _BitmapImage.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            PictBxLoadedImage.Image = bitmapGray;
            PictBxLoadedImage.SizeMode = PictureBoxSizeMode.StretchImage;


            // Meine Lösung langsam.
            //count = 0;

            //for (int y = 0; y < _BitmapImage.Height; y++)
            //{
            //    for (int x = 0; x < _BitmapImage.Width; x++)
            //    {
            //        _BitmapImage.SetPixel(x, y, Color.FromArgb(grayscale[count], grayscale[count], grayscale[count]));
            //        count++;
            //    }
            //}
            //Refresh();
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}