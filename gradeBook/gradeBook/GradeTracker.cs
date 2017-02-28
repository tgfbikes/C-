﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public abstract class GradeTracker
    {
        public abstract void AddGrade(float grade);

        public abstract GradeStatistics ComputeStatistics();

        public abstract void WriteGrades(TextWriter destination);

        public NameChangedDelegate NameChanged;

        protected string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value && NameChanged != null)
                {
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.ExistingName = _name;
                    args.NewName = value;

                    NameChanged(this, args);
                }
                _name = value;
            }
        }
    }
}
