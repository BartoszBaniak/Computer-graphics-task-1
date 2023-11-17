//-----------------------------------------------//
using System.Drawing;
using System;

namespace Graf_kom
{
    public partial class f_graf_kom
    {

        public void Efekt1()
        {
            //effect: image shifts towards the right side

            if (p >= L) p = 0;

            for (int j = 1; j <= L; j++)
            {
                for (int i = 1; i <= p; i++)
                    ReadTlo(N);
                for (int i = 1; i <= K - p; i++)
                    ReadPixel(i, j);
            }
        }

        public void Efekt2()
        {
            //effect: scrolling of the image along the diagonal of the screen towards the upper left apex

            if (p >= L) p = 0;

            for (int j = p + 1; j <= L; j++)
            {
                for (int i = p + 1; i <= K; i++)
                    ReadPixel(i, j);
                for (int i = 1; i <= p; i++)
                    ReadTlo(N);
            }

            for (int j = 1; j <= p; j++)
            {
                for (int i = 1; i <= K - p; i++)
                    ReadTlo(N);
                for (int i = 1; i <= p; i++)
                    ReadPixel(i, j);
            }
        }

        public void Efekt3()
        {
            //effect: obscuring the vertical image towards the top of the screen

            if (p >= L) p = 0;

            for (int j = 1; j <= L - p; j++)
                for (int i = 1; i <= K; i++)
                    ReadPixel(i, j);

            for (int j = 1; j <= p; j++)
                for (int i = 1; i <= K; i++)
                    ReadTlo(N);
        }
        
        public double Percentage (int value)
        {
            if(value < -255 || value > 255)
            {
                throw new ArgumentOutOfRangeException();
            }

            double percentage = (value) / 255.0 * 100;

            return (int)percentage;

        }

        public void Zmien_obraz()
        {

            int brightness = 0;
            int contrast = 0;

            if (radioButtonHLS.Checked)
            {
                m_ekran = ConvertToMonochromeHLS(m_obraz_w_pamieci);
                brightness = (int)DetermineBrightnessHLS(m_obraz_w_pamieci);
                contrast = (int)DetermineContrast(m_obraz_w_pamieci, brightness);
                contrastBar.Enabled = false;
                brightnessBar.Enabled = false;
            }

            if (radioButtonHSV.Checked)
            {
                m_ekran = ConvertToMonochromeHSV(m_obraz_w_pamieci);
                brightness = (int)DetermineBrightnessHSV(m_obraz_w_pamieci);
                contrast = (int)DetermineContrast(m_obraz_w_pamieci, brightness);
                contrastBar.Enabled = false;
                brightnessBar.Enabled = false;
            }

            if (radioButtonAvg.Checked)
            {
                m_ekran = ConvertToMonochromeByAverage(m_obraz_w_pamieci);
                brightness = (int)DetermineBrightnessAvg(m_obraz_w_pamieci);
                contrast = (int)DetermineContrast(m_obraz_w_pamieci, brightness);
                contrastBar.Enabled = false;
                brightnessBar.Enabled = false;
            }

            if (radioButtonBC.Checked)
            {
                m_ekran = changeBrightness(m_obraz_w_pamieci);
                contrastBar.Enabled = true;
                brightnessBar.Enabled = true;
                brightness = (int)DetermineBrightnessRGB(m_ekran);
                contrast = (int)DetermineContrastRGB(m_ekran, brightness);
            }


            double brightnessP = Percentage(brightness);
            double contrastP = Percentage(contrast);

            brightnessLabel.Text = "Brightness: " + brightnessP + "%";
            contrastLabel.Text = "Contrast: " + contrastP + "%";

            SetBitMap(ref m_ekran);
            progressBar1.Value = 0;
        }

        public Bitmap ConvertToMonochromeHLS(Bitmap inputImage)
        {
            Bitmap monochromeImage = new Bitmap(K, L);
            int maxValue = 0;
            int minValue = 0;
            

            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < L; j++)
                {
                    Color pixelColor = inputImage.GetPixel(i, j);
                    maxValue = Math.Max(pixelColor.R, Math.Max(pixelColor.G, pixelColor.B));
                    minValue = Math.Min(pixelColor.R, Math.Min(pixelColor.G, pixelColor.B));
                    int monoValue = (maxValue + minValue) / 2;
                    Color monoColor = Color.FromArgb(monoValue, monoValue, monoValue);
                    monochromeImage.SetPixel(i, j, monoColor);
                }
            }
            return monochromeImage;
        }

        public Bitmap ConvertToMonochromeHSV(Bitmap inputImage)
        {
            Bitmap monochromeImage = new Bitmap(K, L);

            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < L; j++)
                {
                    Color pixelColor = inputImage.GetPixel(i, j);
                    int maxValue = Math.Max(pixelColor.R, Math.Max(pixelColor.G, pixelColor.B));
                    Color monoColor = Color.FromArgb(maxValue, maxValue, maxValue);
                    monochromeImage.SetPixel(i, j, monoColor);
                }
            }
            return monochromeImage;
        }

        public Bitmap ConvertToMonochromeByAverage(Bitmap inputImage)
        {
            Bitmap monochromeImage = new Bitmap(K, L);

            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < L; j++)
                {
                    Color pixelColor = inputImage.GetPixel(i, j);
                    int averageValue = (int)((pixelColor.R + pixelColor.G + pixelColor.B) / 3);
                    Color monoColor = Color.FromArgb(averageValue, averageValue, averageValue);
                    monochromeImage.SetPixel(i, j, monoColor);
                }
            }
            return monochromeImage;
        }


        public double DetermineBrightnessHLS(Bitmap inputImage) 
        {
            int M = inputImage.Width;
            int N = inputImage.Height;
            int J = 0;
            int maxValue = 0;
            int minValue = 0;
            int value = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Color pixelColor = inputImage.GetPixel(i, j);
                    maxValue = Math.Max(pixelColor.R, Math.Max(pixelColor.G, pixelColor.B));
                    minValue = Math.Min(pixelColor.R, Math.Min(pixelColor.G, pixelColor.B));
                    value = (maxValue + minValue) / 2;
                    J += value;
                }
            }
            return (double)(J / (M * N));
        }
        public double DetermineBrightnessHSV(Bitmap inputImage) 
        {
            int M = inputImage.Width;
            int N = inputImage.Height;
            int J = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Color pixelColor = inputImage.GetPixel(i, j);
                    J += (int)(Math.Max(pixelColor.R, Math.Max(pixelColor.G, pixelColor.B)));
                }
            }
            return (double)(J / (M * N));
        }

        public double DetermineBrightnessAvg(Bitmap inputImage) 
        {
            int M = inputImage.Width;
            int N = inputImage.Height;
            int J = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Color pixelColor = inputImage.GetPixel(i, j);
                    J += (int)((pixelColor.R + pixelColor.G + pixelColor.B) / 3);
                }
            }
            return (double)(J / (M * N));
        }

        public double DetermineBrightnessRGB(Bitmap inputImage) 
        {
            int M = inputImage.Width;
            int N = inputImage.Height;
            int J = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Color pixelColor = inputImage.GetPixel(i, j);
                    J += (int)((pixelColor.R + pixelColor.G + pixelColor.B) / 3);
                }
            }
            return (double)(J / (M * N));
        }

        public double DetermineContrast(Bitmap inputImage, int brightness) 
        {
            int M = inputImage.Width;
            int N = inputImage.Height;
            double J = brightness;
            double C = 0;
            double temp = 0;

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Color pixelColor = inputImage.GetPixel(i, j);
                    temp += Math.Pow(((int)(Math.Max(pixelColor.R, Math.Max(pixelColor.G, pixelColor.B))) - J), 2);
                }
            }
            temp = temp / (M * N);
            C = Math.Sqrt(temp);
            return C;
        }

        public double DetermineContrastRGB(Bitmap inputImage, int brightness) 
        {
            int M = inputImage.Width;
            int N = inputImage.Height;
            double J = brightness;
            double C = 0;
            double temp = 0;

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Color pixelColor = inputImage.GetPixel(i, j);
                    temp += Math.Pow(((int)(Math.Max(pixelColor.R, Math.Max(pixelColor.G, pixelColor.B))) - J), 2);
                }
            }
            temp = temp / (M * N);
            C = Math.Sqrt(temp);
            return C;
        }

        public Bitmap changeBrightness(Bitmap inputImage)
        {
            
            int brightness = brightnessBar.Value;
            int M = inputImage.Width;
            int N = inputImage.Height;
            int newR = 0;
            int newG = 0;
            int newB = 0;
            Bitmap outputImage = new Bitmap(K, L);

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Color pixelColor = inputImage.GetPixel(i, j);
                    newR = pixelColor.R + brightness;
                    newG = pixelColor.G + brightness;
                    newB = pixelColor.B + brightness;

                    if(newR > 255)
                    {
                        newR = 255;
                    }else if(newR < 0)
                    {
                        newR = 0;
                    }

                    if (newG > 255)
                    {
                        newG = 255;
                    }
                    else if (newG < 0)
                    {
                        newG = 0;
                    }

                    if (newB > 255)
                    {
                        newB = 255;
                    }
                    else if (newB < 0)
                    {
                        newB = 0;
                    }
                    
                    newR = Math.Max(0, Math.Min((int)(Math.Tan((double)contrastBar.Value / 100) * ((double)newR - 127.5) + 127.5), 255));
                    newG = Math.Max(0, Math.Min((int)(Math.Tan((double)contrastBar.Value / 100) * ((double)newG - 127.5) + 127.5), 255));
                    newB = Math.Max(0, Math.Min((int)(Math.Tan((double)contrastBar.Value / 100) * ((double)newB - 127.5) + 127.5), 255));

                    Color outputColor = Color.FromArgb(newR, newG, newB);
                    outputImage.SetPixel(i, j, outputColor);

                }
            }
            return outputImage;

        }
    }
}
