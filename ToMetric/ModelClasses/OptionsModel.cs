using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToMetric.ModelClasses
{
    class OptionsModel : NotifyingModel
    {
        private bool isCentimeterOn,
                     isFluidOunceOn,
                     isFootOn,
                     isGallonOn,
                     isInchOn,
                     isLiterOn,
                     isMeterOn,
                     isMileToKilometerOn,
                     isMilliliterOn,
                     isMillimeterOn,
                     isOunceToGramsOn,
                     isPintOn,
                     isPoundToKilogramOn,
                     isQuartOn,
                     isSpeedOn,
                     isTemperatureOn,
                     isYardOn;
        private int precision;
        private List<ConversionType> problemPool;

        public OptionsModel(List<ConversionType> problemPool)
        {
            this.problemPool = problemPool;

            try
            {
                Load();
            }
            catch(Exception)
            {
                isCentimeterOn = true;
                isFluidOunceOn = true;
                isFootOn = true;
                isGallonOn = true;
                isInchOn = true;
                isLiterOn = true;
                isMeterOn = true;
                isMileToKilometerOn = true;
                isMilliliterOn = true;
                isMillimeterOn = true;
                isOunceToGramsOn = true;
                isPintOn = true;
                isPoundToKilogramOn = true;
                isQuartOn = true;
                isSpeedOn = true;
                isTemperatureOn = true;
                isYardOn = true;

                precision = 10;
            }
            
            InitProblemPool();
        }

        public bool IsCentimeterOn
        {
            get => isCentimeterOn;
            set
            {
                if (isCentimeterOn != value)
                {
                    isCentimeterOn = value;
                    NotifyPropertyChanged("IsCentimeterOn");

                    if (value)
                    {
                        if (isInchOn)
                        {
                            problemPool.Add(ConversionType.InchToCentimeter);
                        }

                        if (isFootOn)
                        {
                            problemPool.Add(ConversionType.FootToCentimeter);
                        }
                    }
                    else
                    {
                        problemPool.Remove(ConversionType.InchToCentimeter);
                        problemPool.Remove(ConversionType.FootToCentimeter);
                    }
                }
            }
        }

        public bool IsFluidOunceOn
        {
            get => isFluidOunceOn;
            set
            {
                if (isFluidOunceOn != value)
                {
                    isFluidOunceOn = value;
                    NotifyPropertyChanged("IsFluidOunceOn");

                    if (value)
                    {
                        if (isMilliliterOn)
                        {
                            problemPool.Add(ConversionType.FluidOunceToMilliliter);
                        }

                        if (isLiterOn)
                        {
                            problemPool.Add(ConversionType.FluidOunceToLiter);
                        }
                    }
                    else
                    {
                        problemPool.Remove(ConversionType.FluidOunceToMilliliter);
                        problemPool.Remove(ConversionType.FluidOunceToLiter);
                    }
                }
            }
        }

        public bool IsFootOn
        {
            get => isFootOn;
            set
            {
                if (isFootOn != value)
                {
                    isFootOn = value;
                    NotifyPropertyChanged("IsFootOn");

                    if (value)
                    {
                        if (isCentimeterOn)
                        {
                            problemPool.Add(ConversionType.FootToCentimeter);
                        }

                        if (isMeterOn)
                        {
                            problemPool.Add(ConversionType.FootToMeter);
                        }
                    }
                    else
                    {
                        problemPool.Remove(ConversionType.FootToCentimeter);
                        problemPool.Remove(ConversionType.FootToMeter);
                    }
                }
            }
        }

        public bool IsGallonOn
        {
            get => isGallonOn;
            set
            {
                if (isGallonOn != value)
                {
                    isGallonOn = value;
                    NotifyPropertyChanged("IsGallonOn");

                    if (value)
                    {
                        if (isLiterOn)
                        {
                            problemPool.Add(ConversionType.GallonToLiter);
                        }
                    }
                    else
                    {
                        problemPool.Remove(ConversionType.GallonToLiter);
                    }
                }
            }
        }

        public bool IsInchOn
        {
            get => isInchOn;
            set
            {
                if(isInchOn != value)
                {
                    isInchOn = value;
                    NotifyPropertyChanged("IsInchOn");

                    if (value)
                    {
                        if (isMillimeterOn)
                        {
                            problemPool.Add(ConversionType.InchToMillimeter);
                        }

                        if (isCentimeterOn)
                        {
                            problemPool.Add(ConversionType.InchToCentimeter);
                        }
                    }
                    else
                    {
                        problemPool.Remove(ConversionType.InchToCentimeter);
                        problemPool.Remove(ConversionType.InchToMillimeter);
                    }
                }
            }
        }

        public bool IsLiterOn
        {
            get => isLiterOn;
            set
            {
                if (isLiterOn != value)
                {
                    isLiterOn = value;
                    NotifyPropertyChanged("IsLiterOn");

                    if (value)
                    {
                        if (isFluidOunceOn)
                        {
                            problemPool.Add(ConversionType.FluidOunceToLiter);
                        }

                        if (isPintOn)
                        {
                            problemPool.Add(ConversionType.PintToLiter);
                        }

                        if (isQuartOn)
                        {
                            problemPool.Add(ConversionType.QuartToLiter);
                        }

                        if (isGallonOn)
                        {
                            problemPool.Add(ConversionType.GallonToLiter);
                        }
                    }
                    else
                    {
                        problemPool.Remove(ConversionType.FluidOunceToLiter);
                        problemPool.Remove(ConversionType.PintToLiter);
                        problemPool.Remove(ConversionType.QuartToLiter);
                        problemPool.Remove(ConversionType.GallonToLiter);
                    }
                }
            }
        }

        public bool IsMeterOn
        {
            get => isMeterOn;
            set
            {
                if(isMeterOn != value)
                {
                    isMeterOn = value;
                    NotifyPropertyChanged("IsMeterOn");

                    if (value)
                    {
                        if (isFootOn)
                        {
                            problemPool.Add(ConversionType.FootToMeter);
                        }

                        if (isYardOn)
                        {
                            problemPool.Add(ConversionType.YardToMeter);
                        }
                    }
                    else
                    {
                        problemPool.Remove(ConversionType.FootToMeter);
                        problemPool.Remove(ConversionType.YardToMeter);
                    }
                }
            }
        }

        public bool IsMileToKilometerOn
        {
            get => isMileToKilometerOn;
            set
            {
                if (isMileToKilometerOn != value)
                {
                    isMileToKilometerOn = value;
                    NotifyPropertyChanged("IsMileToKilometerOn");

                    if (value)
                    {
                        problemPool.Add(ConversionType.MileToKilometer);
                    }
                    else
                    {
                        problemPool.Remove(ConversionType.MileToKilometer);
                    }
                }
            }
        }

        public bool IsMilliliterOn
        {
            get => isMilliliterOn;
            set
            {
                if (isMilliliterOn != value)
                {
                    isMilliliterOn = value;
                    NotifyPropertyChanged("IsMilliliterOn");

                    if (value)
                    {
                        if (isFluidOunceOn)
                        {
                            problemPool.Add(ConversionType.FluidOunceToMilliliter);
                        }
                    }
                    else
                    {
                        problemPool.Remove(ConversionType.FluidOunceToMilliliter);
                    }
                }
            }
        }

        public bool IsMillimeterOn
        {
            get => isMillimeterOn;
            set
            {
                if(isMillimeterOn != value)
                {
                    isMillimeterOn = value;
                    NotifyPropertyChanged("IsMillimeterOn");

                    if (value)
                    {
                        if (isInchOn)
                        {
                            problemPool.Add(ConversionType.InchToMillimeter);
                        }
                    }
                    else
                    {
                        problemPool.Remove(ConversionType.InchToMillimeter);
                    }
                }
            }
        }

        public bool IsOunceToGramOn
        {
            get => isOunceToGramsOn;
            set
            {
                if(isOunceToGramsOn != value)
                {
                    isOunceToGramsOn = value;
                    NotifyPropertyChanged("IsOunceToGramOn");

                    if (value)
                    {
                        problemPool.Add(ConversionType.OunceToGram);
                    }
                    else
                    {
                        problemPool.Remove(ConversionType.OunceToGram);
                    }
                }
            }
        }

        public bool IsPintOn
        {
            get => isPintOn;
            set
            {
                if (isPintOn != value)
                {
                    isPintOn = value;
                    NotifyPropertyChanged("IsPintOn");

                    if (value)
                    {
                        if (isLiterOn)
                        {
                            problemPool.Add(ConversionType.PintToLiter);
                        }
                    }
                    else
                    {
                        problemPool.Remove(ConversionType.PintToLiter);
                    }
                }
            }
        }

        public bool IsPoundToKilogramOn
        {
            get => isPoundToKilogramOn;
            set
            {
                if(isPoundToKilogramOn != value)
                {
                    isPoundToKilogramOn = value;
                    NotifyPropertyChanged("IsPoundToKilogramOn");

                    if (value)
                    {
                        problemPool.Add(ConversionType.PoundToKilogram);
                    }
                    else
                    {
                        problemPool.Remove(ConversionType.PoundToKilogram);
                    }
                }
            }
        }

        public bool IsQuartOn
        {
            get => isQuartOn;
            set
            {
                if(isQuartOn != value)
                {
                    isQuartOn = value;
                    NotifyPropertyChanged("IsQuartOn");

                    if (value)
                    {
                        if (isLiterOn)
                        {
                            problemPool.Add(ConversionType.QuartToLiter);
                        }
                    }
                    else
                    {
                        problemPool.Remove(ConversionType.QuartToLiter);
                    }
                }
            }
        }

        public bool IsSpeedOn
        {
            get => isSpeedOn;
            set
            {
                if(isSpeedOn != value)
                {
                    isSpeedOn = value;
                    NotifyPropertyChanged("IsSpeedOn");

                    if (value)
                    {
                        problemPool.Add(ConversionType.MilesPerHourToKiloMetersPerHour);
                    }
                    else
                    {
                        problemPool.Remove(ConversionType.MilesPerHourToKiloMetersPerHour);
                    }
                }
            }
        }

        public bool IsTemperatureOn
        {
            get => isTemperatureOn;
            set
            {
                if(isTemperatureOn != value)
                {
                    isTemperatureOn = value;
                    NotifyPropertyChanged("IsTemperatureOn");

                    if (value)
                    {
                        problemPool.Add(ConversionType.FahrenheitToCelsius);
                    }
                    else
                    {
                        problemPool.Remove(ConversionType.FahrenheitToCelsius);
                    }
                }
            }
        }

        public bool IsYardOn
        {
            get => isYardOn;
            set
            {
                if(isYardOn != value)
                {
                    isYardOn = value;
                    NotifyPropertyChanged("IsYardOn");

                    if (value)
                    {
                        if (isMeterOn)
                        {
                            problemPool.Add(ConversionType.YardToMeter);
                        }
                    }
                    else
                    {
                        problemPool.Remove(ConversionType.YardToMeter);
                    }
                }
            }
        }

        public int Precision
        {
            get => precision;
            set
            {
                if (precision != value)
                {
                    precision = value;
                    NotifyPropertyChanged("Precision");
                }
            }
        }

        public void InitProblemPool()
        {
            if (isMillimeterOn && isInchOn)
            {
                problemPool.Add(ConversionType.InchToMillimeter);
            }

            if (isCentimeterOn)
            {
                if (isInchOn)
                {
                    problemPool.Add(ConversionType.InchToCentimeter);
                }

                if (isFootOn)
                {
                    problemPool.Add(ConversionType.FootToCentimeter);
                }
            }

            if (isMeterOn)
            {
                if (isFootOn)
                {
                    problemPool.Add(ConversionType.FootToMeter);
                }

                if (isYardOn)
                {
                    problemPool.Add(ConversionType.YardToMeter);
                }
            }

            if (isMileToKilometerOn)
            {
                problemPool.Add(ConversionType.MileToKilometer);
            }

            if (isTemperatureOn)
            {
                problemPool.Add(ConversionType.FahrenheitToCelsius);
            }

            if (isOunceToGramsOn)
            {
                problemPool.Add(ConversionType.OunceToGram);
            }

            if (isPoundToKilogramOn)
            {
                problemPool.Add(ConversionType.PoundToKilogram);
            }

            if (isFluidOunceOn && isMilliliterOn)
            {
                problemPool.Add(ConversionType.FluidOunceToMilliliter);
            }

            if (isLiterOn)
            {
                if (isFluidOunceOn)
                {
                    problemPool.Add(ConversionType.FluidOunceToLiter);
                }

                if (isPintOn)
                {
                    problemPool.Add(ConversionType.PintToLiter);
                }

                if (isQuartOn)
                {
                    problemPool.Add(ConversionType.QuartToLiter);
                }

                if (isGallonOn)
                {
                    problemPool.Add(ConversionType.GallonToLiter);
                }
            }

            if (isSpeedOn)
            {
                problemPool.Add(ConversionType.MilesPerHourToKiloMetersPerHour);
            }
        }

        /// <summary>
        ///     Loads the options from disk if they exist
        /// </summary>
        public void Load()
        {
            string optionsFilePath = Path.Combine(Directory.GetCurrentDirectory(), "options");

            if (!File.Exists(optionsFilePath))
            {
                throw new FileNotFoundException("Options file not found");
            }

            Options saveData;

            using (FileStream stream = File.Open(optionsFilePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                saveData = (Options)binaryFormatter.Deserialize(stream);
            }
            
            IsCentimeterOn = saveData.isCentimeterOn;
            IsFluidOunceOn = saveData.isFluidOunceOn;
            IsFootOn = saveData.isFootOn;
            IsGallonOn = saveData.isGallonOn;
            IsInchOn = saveData.isInchOn;
            IsLiterOn = saveData.isLiterOn;
            IsMeterOn = saveData.isMeterOn;
            IsMileToKilometerOn = saveData.isMileToKilometerOn;
            IsMilliliterOn = saveData.isMilliliterOn;
            IsMillimeterOn = saveData.isMillimeterOn;
            IsOunceToGramOn = saveData.isOunceToGramOn;
            IsPintOn = saveData.isPintOn;
            IsPoundToKilogramOn = saveData.isPoundToKilogramOn;
            IsQuartOn = saveData.isQuartOn;
            IsSpeedOn = saveData.isSpeedOn;
            IsTemperatureOn = saveData.isTemperatureOn;
            IsYardOn = saveData.isYardOn;
            Precision = saveData.precision;
        }

        /// <summary>
        ///     Saves the options to disk
        /// </summary>
        public void Save()
        {
            Options saveData = new Options(isCentimeterOn, isFluidOunceOn, isFootOn, isGallonOn,
                                           isInchOn, isLiterOn, isMeterOn, isMileToKilometerOn,
                                           isMilliliterOn, isMillimeterOn, IsOunceToGramOn,
                                           IsPintOn, IsPoundToKilogramOn, isQuartOn, isSpeedOn,
                                           isTemperatureOn, isYardOn, precision);

            using (FileStream stream = File.Open(Path.Combine(Directory.GetCurrentDirectory(), "options"), FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, saveData);
            }
        }
    }

    /// <summary>
    ///     A struct of the options model for saving to disk
    /// </summary>
    [Serializable]
    struct Options
    {
        public bool isCentimeterOn,
                    isFluidOunceOn,
                    isFootOn,
                    isGallonOn,
                    isInchOn,
                    isLiterOn,
                    isMeterOn,
                    isMileToKilometerOn,
                    isMilliliterOn,
                    isMillimeterOn,
                    isOunceToGramOn,
                    isPintOn,
                    isPoundToKilogramOn,
                    isQuartOn,
                    isSpeedOn,
                    isTemperatureOn,
                    isYardOn;
        public int precision;

        public Options(bool isCentimeterOn,
                       bool isFluidOunceOn,
                       bool isFootOn, 
                       bool isGallonOn,
                       bool isInchOn,
                       bool isLiterOn,
                       bool isMeterOn,
                       bool isMileToKilometerOn,
                       bool isMilliliterOn,
                       bool isMillimeterOn,
                       bool isOunceToGramOn,
                       bool isPintOn,
                       bool isPoundToKilogramOn,
                       bool isQuartOn,
                       bool isSpeedOn,
                       bool isTemperatureOn,
                       bool isYardOn,
                       int precision)
        {
            this.isCentimeterOn      = isCentimeterOn;
            this.isFluidOunceOn      = isFluidOunceOn;
            this.isFootOn            = isFootOn;
            this.isGallonOn          = isGallonOn;
            this.isInchOn            = isInchOn;
            this.isLiterOn           = isLiterOn;
            this.isMeterOn           = isMeterOn;
            this.isMileToKilometerOn = isMileToKilometerOn;
            this.isMilliliterOn      = isMilliliterOn;
            this.isMillimeterOn      = isMillimeterOn;
            this.isOunceToGramOn     = isOunceToGramOn;
            this.isPintOn            = isPintOn;
            this.isPoundToKilogramOn = isPoundToKilogramOn;
            this.isQuartOn           = isQuartOn;
            this.isSpeedOn           = isSpeedOn;
            this.isTemperatureOn     = isTemperatureOn;
            this.isYardOn            = isYardOn;
            this.precision           = precision;
        }
    }
}