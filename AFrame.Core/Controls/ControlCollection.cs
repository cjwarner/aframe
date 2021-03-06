﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFrame.Core
{
    public abstract class ControlCollection<T> : Control, IEnumerable<T> where T : Control
    {
        protected IEnumerable<SearchProperty> _searchParameters;

        public ControlCollection(IContext context, Technology technology, IEnumerable<SearchProperty> searchParameters) 
            :base(context, technology)
        {
            this._searchParameters = searchParameters;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.FindControls().GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.FindControls().GetEnumerator();
        }

        private IEnumerable<T> FindControls()
        {
            return (IEnumerable<T>)this.RawFind();
        }
    }
}