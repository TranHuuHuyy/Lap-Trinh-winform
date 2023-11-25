using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GongMe.DataTier.Models;
using GongMe.DataTier;
using GongMe.ViewModel;

namespace GongMe.BusinessTier
{
    internal class CTPNBUS
    {
       
            private CTPNDAL CTPNDAL;
            public CTPNBUS()
            {
                CTPNDAL = new CTPNDAL();
            }
            public IEnumerable<CTPNViewModel> GetCTPN(int maPhieuNhap)
            {
                return CTPNDAL.GetCTPN(maPhieuNhap);
            }
           
            public bool ThemCTPhieu(CTPN cTPN)
            {
                try
                {
                    return CTPNDAL.ThemCTPhieu(cTPN);
                }
                catch (Exception ex) { throw ex; }
            }
            public bool XoaCTPN(CTPN CTPN)
            {
                try
                {
                    return CTPNDAL.XoaCTPN(CTPN);
                }
                catch (Exception ex) { throw ex; }
            }

            public List<CTPN> getListCTPNTheoMa(int maPhieuNhap)
            {
                return CTPNDAL.getListCTPNTheoMa(maPhieuNhap);
            }

            public bool SuaCTPN(CTPN CTPN)
            {
                try
                {
                    return CTPNDAL.SuaCTPN(CTPN);
                }
                catch (Exception ex) { throw ex; }
            }

            public CTPN getCTPNTheoMa(int maPhieuNhap)
            {
                return CTPNDAL.getCTPNTheoMa( maPhieuNhap);
            }

       /* internal static CTPN getCTPNsTheoMa(int maPhieuNhap)
        {
            throw new NotImplementedException();
        }*/

       

       /* internal static void ThemCTPN(CTPN cTPN)
        {
            throw new NotImplementedException();
        }*/

       /*public List<CTPN> getListCTPNsTheoMa(int maPhieuNhap)
        {
            throw new NotImplementedException();
        }*/

       /* internal void ThemCTPN(CTPN cTPN)
        {
            throw new NotImplementedException();
        }*/
    }
}
