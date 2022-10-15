using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace k191373_Q3
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Category(int n)
        {
            switch (n)
            {
                case 1:
                    this.Name= "AUTOMOBILE ASSEMBLER";
                    break;
                case 2:
                    this.Name= "AUTOMOBILE PARTS & ACCESSORIES";
                    break;
                case 3:
                    this.Name= "CABLE & ELECTRICAL GOODS";
                    break;
                case 4:
                    this.Name = "CEMENT";
                    break;
                case 5:
                    this.Name = "CHEMICAL";
                    break;
                case 6:
                    this.Name = "CLOSE - END MUTUAL FUND";
                    break;
                case 7:
                    this.Name = "COMMERCIAL BANKS";
                    break;
                case 8:
                    this.Name = "ENGINEERING";
                    break;
                case 9:
                    this.Name = "EXCHANGE TRADED FUNDS";
                    break;
                case 10:
                    this.Name = "FERTILIZER";
                    break;
                case 11:
                    this.Name = "FOOD & PERSONAL CARE PRODUCTS";
                    break;
                case 12:
                    this.Name = "FUTURE CONTRACTS";
                    break;
                case 13:
                    this.Name = "GLASS & CERAMICS";
                    break;
                case 14:
                    this.Name = "INSURANCE";
                    break;
                case 15:
                    this.Name = "INV. BANKS  INV. COS.  SECURITIES COS";
                    break;
                case 16:
                    this.Name = "JUTE";
                    break;
                case 17:
                    this.Name = "LEASING COMPANIES";
                    break;
                case 18:
                    this.Name = "LEATHER & TANNERIES";
                    break;
                case 19:
                    this.Name = "MISCELLANEOUS";
                    break;
                case 20:
                    this.Name = "MODARABAS";
                    break;
                case 21:
                    this.Name = "OIL & GAS EXPLORATION COMPANIES";
                    break;
                case 22:
                    this.Name = "OIL & GAS MARKETING COMPANIES";
                    break;
                case 23:
                    this.Name = "PAPER & BOARD";
                    break;                
                case 24:
                    this.Name = "PHARMACEUTICALS";
                    break;
                case 25:
                    this.Name = "POWER GENERATION & DISTRIBUTION";
                    break;
                case 26:
                    this.Name = "PROPERTY";
                    break;
                case 27:
                    this.Name = "REAL ESTATE INVESTMENT TRUST";
                    break;
                case 28:
                    this.Name = "REFINERY";
                    break;
                case 29:
                    this.Name = "SUGAR & ALLIED INDUSTRIES";
                    break;
                case 30:
                    this.Name = "SYNTHETIC & RAYON";
                    break;
                case 31:
                    this.Name = "TECHNOLOGY & COMMUNICATION";
                    break;
                case 32:
                    this.Name = "TEXTILE COMPOSITE";
                    break;
                case 33:
                    this.Name = "TEXTILE SPINNING";
                    break;
                case 34:
                    this.Name = "TEXTILE WEAVING";
                    break;
                case 35:
                    this.Name = "TOBACCO";
                    break;
                case 36:
                    this.Name = "TRANSPORT";
                    break;
                case 37:
                    this.Name = "VANASPATI & ALLIED INDUSTRIES";
                    break;
                case 38:
                    this.Name = "WOOLLEN";
                    break;
                default:
                    this.Name = " ";
                    break;
            }
        }
        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

