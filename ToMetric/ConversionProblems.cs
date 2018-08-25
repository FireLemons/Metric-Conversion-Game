using System;

namespace ToMetric
{
    static class Error
    {
        public static double GetPercentageError(double exactAnswer, double guessedAnswer)
        {
            if (exactAnswer == 0)
            {
                return Math.Abs((guessedAnswer - exactAnswer)) / 1;
            }

            return Math.Abs((guessedAnswer - exactAnswer) / exactAnswer);
        }
    }

    abstract class ConversionProblem
    {
        public abstract double ConvertFrom
        {
            get;
        }

        public abstract double ConvertTo
        {
            get;
        }

        public abstract string Formula
        {
            get;
        }

        public abstract string FromAbbreviation
        {
            get;
        }

        public abstract string ToAbbreviation
        {
            get;
        }

        public ConversionProblem(int score)
        {

        }

        abstract protected double Convert(double customary);
    }

    class InchToMillimeterProblem : ConversionProblem
    {
        private readonly double convertFrom,
                                convertTo;
        private readonly string formula,
                                fromAbbreviation,
                                toAbbreviation;

        public InchToMillimeterProblem(int score) : base(score)
        {
            Random random = new Random();
            convertFrom = (double)random.Next(1, 8 + score) / 8;
            convertTo = Convert(convertFrom);

            formula = "25.4 * in => mm";
            fromAbbreviation = "in";
            toAbbreviation = "mm";
        }

        public override double ConvertFrom
        {
            get => convertFrom;
        }

        public override double ConvertTo
        {
            get => convertTo;
        }

        public override string Formula
        {
            get => formula;
        }

        public override string FromAbbreviation
        {
            get => fromAbbreviation;
        }

        public override string ToAbbreviation
        {
            get => toAbbreviation;
        }

        protected override double Convert(double customary)
        {
            return 25.4 * customary;
        }
    }

    class InchToCentimeterProblem : ConversionProblem
    {
        private readonly double convertFrom,
                                convertTo;
        private readonly string formula,
                                fromAbbreviation,
                                toAbbreviation;

        public InchToCentimeterProblem(int score) : base(score)
        {
            Random random = new Random();
            convertFrom = (double)random.Next(1, 40 + score) / 4;
            convertTo = Convert(convertFrom);

            formula = "2.54 * in => cm";
            fromAbbreviation = "in";
            toAbbreviation = "cm";
        }

        public override double ConvertFrom
        {
            get => convertFrom;
        }

        public override double ConvertTo
        {
            get => convertTo;
        }

        public override string Formula
        {
            get => formula;
        }

        public override string FromAbbreviation
        {
            get => fromAbbreviation;
        }

        public override string ToAbbreviation
        {
            get => toAbbreviation;
        }

        protected override double Convert(double customary)
        {
            return 2.54 * customary;
        }
    }

    class FootToCentimeterProblem : ConversionProblem
    {
        private readonly double convertFrom,
                                convertTo;
        private readonly string formula,
                                fromAbbreviation,
                                toAbbreviation;

        public FootToCentimeterProblem(int score) : base(score)
        {
            Random random = new Random();
            convertFrom = (double)random.Next(1, 6 + score) / 2;
            convertTo = Convert(convertFrom);

            formula = "30.48 * ft => cm";
            fromAbbreviation = "ft";
            toAbbreviation = "cm";
        }

        public override double ConvertFrom
        {
            get => convertFrom;
        }

        public override double ConvertTo
        {
            get => convertTo;
        }

        public override string Formula
        {
            get => formula;
        }

        public override string FromAbbreviation
        {
            get => fromAbbreviation;
        }

        public override string ToAbbreviation
        {
            get => toAbbreviation;
        }

        protected override double Convert(double customary)
        {
            return 30.48 * customary;
        }
    }

    class FootToMeterProblem : ConversionProblem
    {
        private readonly double convertFrom,
                                convertTo;
        private readonly string formula,
                                fromAbbreviation,
                                toAbbreviation;

        public FootToMeterProblem(int score) : base(score)
        {
            Random random = new Random();
            convertFrom = (double)random.Next(1, 6 + score) / 2;
            convertTo = Convert(convertFrom);

            formula = ".3048 * ft => m";
            fromAbbreviation = "ft";
            toAbbreviation = "m";
        }

        public override double ConvertFrom
        {
            get => convertFrom;
        }

        public override double ConvertTo
        {
            get => convertTo;
        }

        public override string Formula
        {
            get => formula;
        }

        public override string FromAbbreviation
        {
            get => fromAbbreviation;
        }

        public override string ToAbbreviation
        {
            get => toAbbreviation;
        }

        protected override double Convert(double customary)
        {
            return .3048 * customary;
        }
    }

    class YardToMeterProblem : ConversionProblem
    {
        private readonly double convertFrom,
                                convertTo;
        private readonly string formula,
                                fromAbbreviation,
                                toAbbreviation;

        public YardToMeterProblem(int score) : base(score)
        {
            Random random = new Random();
            convertFrom = (double)random.Next(1, 10 + score) / 2;
            convertTo = Convert(convertFrom);

            formula = ".9144 * yd => m";
            fromAbbreviation = "yd";
            toAbbreviation = "m";
        }

        public override double ConvertFrom
        {
            get => convertFrom;
        }

        public override double ConvertTo
        {
            get => convertTo;
        }

        public override string Formula
        {
            get => formula;
        }

        public override string FromAbbreviation
        {
            get => fromAbbreviation;
        }

        public override string ToAbbreviation
        {
            get => toAbbreviation;
        }

        protected override double Convert(double customary)
        {
            return .9144 * customary;
        }
    }

    class MileToKilometerProblem : ConversionProblem
    {
        private readonly double convertFrom,
                                convertTo;
        private readonly string formula,
                                fromAbbreviation,
                                toAbbreviation;

        public MileToKilometerProblem(int score) : base(score)
        {
            Random random = new Random();
            convertFrom = (double)random.Next(1, 10 + 4 * score) / 2;
            convertTo = Convert(convertFrom);

            formula = "1.609344 * mi => km";
            fromAbbreviation = "mi";
            toAbbreviation = "km";
        }

        public override double ConvertFrom
        {
            get => convertFrom;
        }

        public override double ConvertTo
        {
            get => convertTo;
        }

        public override string Formula
        {
            get => formula;
        }
        public override string FromAbbreviation
        {
            get => fromAbbreviation;
        }

        public override string ToAbbreviation
        {
            get => toAbbreviation;
        }

        protected override double Convert(double customary)
        {
            return 1.609344 * customary;
        }
    }

    class FahrenheitToCelsiusProblem : ConversionProblem
    {
        private readonly double convertFrom,
                                convertTo;
        private readonly string formula,
                                fromAbbreviation,
                                toAbbreviation;

        public FahrenheitToCelsiusProblem(int score) : base(score)
        {
            Random random = new Random();
            convertFrom = random.Next(0 - (score / 2), 60 + score);
            convertTo = Convert(convertFrom);

            formula = "(°F - 32) * 5 / 9 => °C";
            fromAbbreviation = "°F";
            toAbbreviation = "°C";
        }

        public override double ConvertFrom
        {
            get => convertFrom;
        }

        public override double ConvertTo
        {
            get => convertTo;
        }

        public override string Formula
        {
            get => formula;
        }

        public override string FromAbbreviation
        {
            get => fromAbbreviation;
        }

        public override string ToAbbreviation
        {
            get => toAbbreviation;
        }

        protected override double Convert(double customary)
        {
            return (customary - 32) * 5 / 9;
        }
    }

    class OunceToGramProblem : ConversionProblem
    {
        private readonly double convertFrom,
                                convertTo;
        private readonly string formula,
                                fromAbbreviation,
                                toAbbreviation;

        public OunceToGramProblem(int score) : base(score)
        {
            Random random = new Random();
            convertFrom = random.Next(1, 1 + score);
            convertTo = Convert(convertFrom);

            formula = "28.34952 * oz => g";
            fromAbbreviation = "oz";
            toAbbreviation = "g";
        }

        public override double ConvertFrom
        {
            get => convertFrom;
        }

        public override double ConvertTo
        {
            get => convertTo;
        }

        public override string Formula
        {
            get => formula;
        }

        public override string FromAbbreviation
        {
            get => fromAbbreviation;
        }

        public override string ToAbbreviation
        {
            get => toAbbreviation;
        }

        protected override double Convert(double customary)
        {
            return 28.34952 * customary;
        }
    }

    class PoundToKilogramProblem : ConversionProblem
    {
        private readonly double convertFrom,
                                convertTo;
        private readonly string formula,
                                fromAbbreviation,
                                toAbbreviation;

        public PoundToKilogramProblem(int score) : base(score)
        {
            Random random = new Random();
            convertFrom = random.Next(1, 1 + score);
            convertTo = Convert(convertFrom);

            formula = "0.45359237 * lbs => kg";
            fromAbbreviation = "lb";
            toAbbreviation = "kg";
        }

        public override double ConvertFrom
        {
            get => convertFrom;
        }

        public override double ConvertTo
        {
            get => convertTo;
        }

        public override string Formula
        {
            get => formula;
        }

        public override string FromAbbreviation
        {
            get => fromAbbreviation;
        }

        public override string ToAbbreviation
        {
            get => toAbbreviation;
        }

        protected override double Convert(double customary)
        {
            return 0.45359237 * customary;
        }
    }

    class FluidOunceToMilliliterProblem : ConversionProblem
    {
        private readonly double convertFrom,
                                convertTo;
        private readonly string formula,
                                fromAbbreviation,
                                toAbbreviation;

        public FluidOunceToMilliliterProblem(int score) : base(score)
        {
            Random random = new Random();
            convertFrom = random.Next(1, 1 + (score - random.Next(0, score))) * 4;
            convertTo = Convert(convertFrom);

            formula = "29.5735 * fl oz => mL";
            fromAbbreviation = "fl oz";
            toAbbreviation = "mL";
        }

        public override double ConvertFrom
        {
            get => convertFrom;
        }

        public override double ConvertTo
        {
            get => convertTo;
        }

        public override string Formula
        {
            get => formula;
        }

        public override string FromAbbreviation
        {
            get => fromAbbreviation;
        }

        public override string ToAbbreviation
        {
            get => toAbbreviation;
        }

        protected override double Convert(double customary)
        {
            return 29.5735 * customary;
        }
    }

    class FluidOunceToLiterProblem : ConversionProblem
    {
        private readonly double convertFrom,
                                convertTo;
        private readonly string formula,
                                fromAbbreviation,
                                toAbbreviation;

        public FluidOunceToLiterProblem(int score) : base(score)
        {
            Random random = new Random();
            convertFrom = random.Next(1, 1 + score) * 16;
            convertTo = Convert(convertFrom);

            formula = "0.029573 * fl oz => L";
            fromAbbreviation = "fl oz";
            toAbbreviation = "L";
        }

        public override double ConvertFrom
        {
            get => convertFrom;
        }

        public override double ConvertTo
        {
            get => convertTo;
        }

        public override string Formula
        {
            get => formula;
        }

        public override string FromAbbreviation
        {
            get => fromAbbreviation;
        }

        public override string ToAbbreviation
        {
            get => toAbbreviation;
        }

        protected override double Convert(double customary)
        {
            return 0.029573 * customary;
        }
    }

    class PintToLiterProblem : ConversionProblem
    {
        private readonly double convertFrom,
                                convertTo;
        private readonly string formula,
                                fromAbbreviation,
                                toAbbreviation;

        public PintToLiterProblem(int score) : base(score)
        {
            Random random = new Random();
            convertFrom = random.Next(1, 1 + score);
            convertTo = Convert(convertFrom);

            formula = "0.473176 * pt => L";
            fromAbbreviation = "pt";
            toAbbreviation = "L";
        }

        public override double ConvertFrom
        {
            get => convertFrom;
        }

        public override double ConvertTo
        {
            get => convertTo;
        }

        public override string Formula
        {
            get => formula;
        }

        public override string FromAbbreviation
        {
            get => fromAbbreviation;
        }

        public override string ToAbbreviation
        {
            get => toAbbreviation;
        }

        protected override double Convert(double customary)
        {
            return 0.473176 * customary;
        }
    }

    class QuartToLiterProblem : ConversionProblem
    {
        private readonly double convertFrom,
                                convertTo;
        private readonly string formula,
                                fromAbbreviation,
                                toAbbreviation;

        public QuartToLiterProblem(int score) : base(score)
        {
            Random random = new Random();
            convertFrom = random.Next(1, 5 + score);
            convertTo = Convert(convertFrom);

            formula = "0.946353 * qt => L";
            fromAbbreviation = "qt";
            toAbbreviation = "L";
        }

        public override double ConvertFrom
        {
            get => convertFrom;
        }

        public override double ConvertTo
        {
            get => convertTo;
        }

        public override string Formula
        {
            get => formula;
        }

        public override string FromAbbreviation
        {
            get => fromAbbreviation;
        }

        public override string ToAbbreviation
        {
            get => toAbbreviation;
        }

        protected override double Convert(double customary)
        {
            return 0.946353 * customary;
        }
    }

    class GallonToLiterProblem : ConversionProblem
    {
        private readonly double convertFrom,
                                convertTo;
        private readonly string formula,
                                fromAbbreviation,
                                toAbbreviation;

        public GallonToLiterProblem(int score) : base(score)
        {
            Random random = new Random();
            convertFrom = random.Next(1, 3 + score);
            convertTo = Convert(convertFrom);

            formula = "3.78541 * gal => L";
            fromAbbreviation = "gal";
            toAbbreviation = "L";
        }

        public override double ConvertFrom
        {
            get => convertFrom;
        }

        public override double ConvertTo
        {
            get => convertTo;
        }

        public override string Formula
        {
            get => formula;
        }

        public override string FromAbbreviation
        {
            get => fromAbbreviation;
        }

        public override string ToAbbreviation
        {
            get => toAbbreviation;
        }

        protected override double Convert(double customary)
        {
            return 3.78541 * customary;
        }
    }

    class MilesPerHourToKiloMetersPerHourProblem : ConversionProblem
    {
        private readonly double convertFrom,
                                   convertTo;
        private readonly string formula,
                                fromAbbreviation,
                                toAbbreviation;

        public MilesPerHourToKiloMetersPerHourProblem(int score) : base(score)
        {
            Random random = new Random();
            convertFrom = (double)random.Next(1, 10 + 4 * score) / 2;
            convertTo = Convert(convertFrom);

            formula = "1.609344 * mph => kph";
            fromAbbreviation = "mph";
            toAbbreviation = "kph";
        }

        public override double ConvertFrom
        {
            get => convertFrom;
        }

        public override double ConvertTo
        {
            get => convertTo;
        }

        public override string Formula
        {
            get => formula;
        }
        public override string FromAbbreviation
        {
            get => fromAbbreviation;
        }

        public override string ToAbbreviation
        {
            get => toAbbreviation;
        }

        protected override double Convert(double customary)
        {
            return 1.609344 * customary;
        }
    }
}
