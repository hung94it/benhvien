using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiabetesDido.ClassificationLogic
{
    class Percent
    {
        private string name;
        private int value;

        public int Value
        {
            get { return this.value; }
            private set { this.value = value; }
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public Percent(string name, int value)
        {
            this.name = name;
            this.value = value;
        }
    }
}
