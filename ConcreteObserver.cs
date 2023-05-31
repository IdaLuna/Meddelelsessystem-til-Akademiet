
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class ConcreteObserver : Observer
    {
        private ConcreteSubject subject { get; set; }
        public int State = 0;

        public ConcreteObserver(ConcreteSubject subject) 
        { 
            this.subject = subject; //så Update() metoden virker
        }
        public override void Update()
        {
                this.State = subject.State;
        }
    }
}
