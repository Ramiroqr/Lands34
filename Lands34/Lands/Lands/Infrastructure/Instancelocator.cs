﻿namespace Lands.Infrastructure
{
    using Lands.ViewModels;
    class Instancelocator
    {
        #region Properties
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public Instancelocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
