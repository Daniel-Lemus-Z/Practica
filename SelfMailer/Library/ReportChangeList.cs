﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfMailer.Library
{
    public class ReportChangeList<T> : IReportChildrenChange, IEnumerable<T> where T : IReportChange, IKey
    {
        protected List<T> children;
        protected bool hasChanged;

        public ReportChangeList()
        {
            this.children = new List<T>();
        }

        public bool HasChanged
        {
            get
            {
                bool result = false;
                foreach (IReportChange child in this.children)
                    if (child.HasChanged)
                    {
                        result = true;
                        break;
                    }
                return this.hasChanged || result;
            }

            set
            {
                if (this.HasChanged != value)
                {
                    this.hasChanged = value;
                    if (this.Changed != null)
                        this.Changed(this, new ChangedEventArgs(this.hasChanged));
                }
                if (!value)
                {
                    foreach (IReportChange child in this.children)
                        child.HasChanged = value;
                }
            }
        }

        public T this[string Key]
        {
            get
            {
                foreach (T aChild in this.children)
                {
                    if (((IKey)aChild).Key.Equals(Key))
                    {
                        return aChild;
                    }
                }
                return default(T);
            }
            set
            {
                for (int i = 0; i < this.children.Count; i++)
                {
                    IKey aChild = (IKey)this.children[i];
                    if (aChild.Key.Equals(Key))
                    {
                        this.children[i] = value;
                        this.HasChanged = true;
                        break;
                    }
                }
            }
        }

        public event EventHandler<ChangedEventArgs> Changed;

        public void ChildChanged(object sender, ChangedEventArgs e)
        {
            if (this.Changed != null)
                this.Changed(sender, e);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.children.Count; i++)
            {
                yield return this.children[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T Child)
        {
            IKey childKey = (IKey)Child;
            if (this[childKey.Key] == null)
            {
                IReportChange child = (IReportChange)Child;
                child.Changed += new EventHandler<ChangedEventArgs>(ChildChanged);
                this.children.Add(Child);
            }
        }

        public void Remove(string Key)
        {
            if (this[Key] != null)
            {
                this.children.Remove(this[Key]);
                this.HasChanged = true;
            }
        }
    }
}
