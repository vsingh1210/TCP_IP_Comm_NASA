using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    protected class JSInterface
    {
        String r;
        String theta;
        
        public JSInterface getObj(String r, String theta)
        {
            this.r = r;
            this.theta = theta;
            return this;
        }
    }
}
