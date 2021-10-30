using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewGroup
{
  public  class Country : List<City>
    {
      public string CountryName { get; set; }
        public Country(string nameinit)
        {
            CountryName = nameinit;
        }
    }
}
