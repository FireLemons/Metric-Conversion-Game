namespace ToMetric.ModelClasses
{
    /// <summary>
    ///     Stores boolean that determines whether the window shows the game or the options
    /// </summary>
    class TabModel : NotifyingModel
    {
        private bool isGame;

        public TabModel()
        {
            isGame = true;
        }

        public bool IsGame
        {
            get => isGame;
            set
            {
                if(isGame != value)
                {
                    isGame = value;
                    NotifyPropertyChanged("IsGame");
                }
            }
        }
    }
}
