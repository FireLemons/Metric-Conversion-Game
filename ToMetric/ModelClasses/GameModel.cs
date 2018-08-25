using System;
using System.Collections.Generic;

namespace ToMetric.ModelClasses
{
    class GameModel : NotifyingModel
    {
        private bool? wasRight;
        private int score;
        private double convertFrom,
                       convertTo,
                       error;
        private string formula,
                       fromAbbreviation,
                       toAbbreviation,
                       userInput;
        private List<ConversionType> problemPool;

        public GameModel(List<ConversionType> problemPool)
        {
            error = 0;
            score = 0;
            userInput = "";
            this.problemPool = problemPool;

            GenerateProblem();
        }

        public bool? WasRight
        {
            get => wasRight;
            set
            {
                if(wasRight != value)
                {
                    wasRight = value;
                    NotifyPropertyChanged("WasRight");
                }
            }
        }

        public double Error
        {
            get => error;
            set
            {
                if(error != value)
                {
                    error = value;
                    NotifyPropertyChanged("Error");
                }
            }
        }

        public int Score
        {
            get => score;
            set
            {
                if(score != value)
                {
                    score = value;
                    NotifyPropertyChanged("Score");
                }
            }
        }

        public string UserInput
        {
            get => userInput;
            set
            {
                if(userInput != value)
                {
                    userInput = value;
                    NotifyPropertyChanged("UserInput");
                }
            }
        }

        public double ConvertFrom
        {
            get => convertFrom;
            set
            {
                if (convertFrom != value)
                {
                    convertFrom = value;
                    NotifyPropertyChanged("ConvertFrom");
                }
            }
        }

        public string Formula
        {
            get => formula;
            set
            {
                if(formula != value)
                {
                    formula = value;
                    NotifyPropertyChanged("Formula");
                }
            }
        }

        public string FromAbbreviation
        {
            get => fromAbbreviation;
            set
            {
                if (fromAbbreviation != value)
                {
                    fromAbbreviation = value;
                    NotifyPropertyChanged("FromAbbreviation");
                }
            }
        }

        public string ToAbbreviation
        {
            get => toAbbreviation;
            set
            {
                if (toAbbreviation != value)
                {
                    toAbbreviation = value;
                    NotifyPropertyChanged("ToAbbreviation");
                }
            }
        }

        public void Evaluate(int precision)
        {
            Error = ToMetric.Error.GetPercentageError(convertTo, double.Parse(userInput)) * 100;
            Console.WriteLine("Error is" + error);
            Console.WriteLine("Precision is" + precision);
            if (error < precision)
            {
                Score++;
                UserInput = "";
                GenerateProblem();
                WasRight = true;
            }
            else
            {
                Score = Math.Max(0, score - 5);
                WasRight = false;
            }
        }

        public void GenerateProblem()
        {
            ConversionProblem problem = null;

            if(problemPool.Count > 0)
            {
                switch (problemPool[new Random().Next(0, problemPool.Count - 1)])
                {
                    case ConversionType.FahrenheitToCelsius:
                        problem = new FahrenheitToCelsiusProblem(score);
                        break;
                    case ConversionType.FluidOunceToLiter:
                        problem = new FluidOunceToLiterProblem(score);
                        break;
                    case ConversionType.FluidOunceToMilliliter:
                        problem = new FluidOunceToMilliliterProblem(score);
                        break;
                    case ConversionType.FootToCentimeter:
                        problem = new FootToCentimeterProblem(score);
                        break;
                    case ConversionType.FootToMeter:
                        problem = new FootToMeterProblem(score);
                        break;
                    case ConversionType.GallonToLiter:
                        problem = new GallonToLiterProblem(score);
                        break;
                    case ConversionType.InchToCentimeter:
                        problem = new InchToCentimeterProblem(score);
                        break;
                    case ConversionType.InchToMillimeter:
                        problem = new InchToMillimeterProblem(score);
                        break;
                    case ConversionType.MilesPerHourToKiloMetersPerHour:
                        problem = new MilesPerHourToKiloMetersPerHourProblem(score);
                        break;
                    case ConversionType.MileToKilometer:
                        problem = new MileToKilometerProblem(score);
                        break;
                    case ConversionType.OunceToGram:
                        problem = new OunceToGramProblem(score);
                        break;
                    case ConversionType.PintToLiter:
                        problem = new PintToLiterProblem(score);
                        break;
                    case ConversionType.PoundToKilogram:
                        problem = new PoundToKilogramProblem(score);
                        break;
                    case ConversionType.QuartToLiter:
                        problem = new QuartToLiterProblem(score);
                        break;
                    case ConversionType.YardToMeter:
                        problem = new YardToMeterProblem(score);
                        break;
                }
            }

            if(problem != null)
            {
                ConvertFrom = problem.ConvertFrom;
                convertTo = problem.ConvertTo;
                Formula = problem.Formula;
                FromAbbreviation = problem.FromAbbreviation;
                ToAbbreviation = problem.ToAbbreviation;
            }
        }
    }
}