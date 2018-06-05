using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imagica.API.Application.Models
{
    public class OPTIONTYPE
    {
        public List<string> C { get; set; }
        public List<string> P { get; set; }
    }

    public class CURRENCY
    {
        public List<string> CHF { get; set; }
        public List<string> GBP { get; set; }
        public List<string> AUD { get; set; }
        public List<string> JPY { get; set; }
        public List<string> DKK { get; set; }
        public List<string> EUR { get; set; }
        public List<string> HKD { get; set; }
        public List<string> ILS { get; set; }
        public List<string> INR { get; set; }
        public List<string> NOK { get; set; }
        public List<string> KRW { get; set; }
        public List<string> SEK { get; set; }
        public List<string> SGD { get; set; }
        public List<string> TRY { get; set; }
        public List<string> TWD { get; set; }
        public List<string> USD { get; set; }
    }

    public class BROKERFEESCCY
    {
        public List<string> CHF { get; set; }
        public List<string> GBP { get; set; }
        public List<string> AUD { get; set; }
        public List<string> JPY { get; set; }
        public List<string> DKK { get; set; }
        public List<string> EUR { get; set; }
        public List<string> HKD { get; set; }
        public List<string> ILS { get; set; }
        public List<string> INR { get; set; }
        public List<string> NOK { get; set; }
        public List<string> KRW { get; set; }
        public List<string> SEK { get; set; }
        public List<string> SGD { get; set; }
        public List<string> TRY { get; set; }
        public List<string> TWD { get; set; }
        public List<string> USD { get; set; }
    }

    public class BUYSELL
    {
        public List<string> BUY { get; set; }
        public List<string> SELL { get; set; }
    }

//    public class UNDERLYINGNAME
//{
//    public List<string> HSCE { get; set; }
//    public List<string> KS200 { get; set; }
//    public List<string> FTSE { get; set; }
//    public List<string> NIKKEI { get; set; }
//    public List<string> STOX5E_X { get; set; }
//    public List<string> HANGSENG { get; set; }
//    public List<string> DAX_X { get; set; }
//    public List<string> SX7E { get; set; }
//    public List<string> OMX { get; set; }
//    public List<string> NDUEEGFA { get; set; }
//    public List<string> CAC40_X { get; set; }
//    public List<string> NDEUSIA { get; set; }
//    public List<string> SMI { get; set; }




//        //ICPH - Imagica Custom Property hyphen (hyphen replaced with double underscore)
//        public List<string> __ICPH__MSCI__SIN { get; set; }



//    public List<string> M1CNX { get; set; }
//    public List<string> __ICPH__SX5ED__BK { get; set; }
//    public List<string> SP500 { get; set; }
//    public List<string> NDDUJN { get; set; }
//    public List<string> NDEUINF { get; set; }
//    public List<string> M1MY { get; set; }
//    public List<string> NDEUTHF { get; set; }
//    public List<string> NESTLE { get; set; }
//    public List<string> __ICPH__DAIMLER__CHRYS_X { get; set; }
//    public List<string> NDEUSTW { get; set; }
//    public List<string> AORD200 { get; set; }
//    public List<string> SPMIB_X { get; set; }
//    public List<string> __ICPH__BANCA__INTESA_X { get; set; }
//    public List<string> __ICPH__MSCI__TWD { get; set; }
//    public List<string> SXXP { get; set; }
//    public List<string> M1HK { get; set; }

//        //ICPD - Imagica Custom Property Dot (dot replaced with double underscore)
//        public List<string> __ICPD__INGN__AS_X { get; set; }




//    public List<string> ROCG { get; set; }
//    public List<string> SIEMENS_X { get; set; }
//    public List<string> __ICPH__CREDIT__ORDINA_X { get; set; }
//    public List<string> NDEUPHF { get; set; }
//    public List<string> NDEUSKO { get; set; }
//    public List<string> BAYER_X { get; set; }
//    public List<string> NDDUAS { get; set; }
//    public List<string> M1MS { get; set; }
//    public List<string> TOTAL_X { get; set; }
//    public List<string> __invalid_name__BPA.L { get; set; }
//    public List<string> __invalid_name__DT-TELEKOM_X { get; set; }
//    public List<string> __invalid_name__GLEN.L { get; set; }
//    public List<string> __invalid_name__TCS.IN { get; set; }
//    public List<string> __invalid_name__RIO.L { get; set; }
//    public List<string> __invalid_name__DEUTSCHE-BANK_X { get; set; }
//    public List<string> NOVAEX { get; set; }
//    public List<string> __invalid_name__TELCD.IN { get; set; }
//    public List<string> __invalid_name__VOD.L { get; set; }
//    public List<string> __invalid_name__AZN.L { get; set; }
//    public List<string> __invalid_name__SOCIETE-GLE_X { get; set; }
//    public List<object> __invalid_name__TRN.MI { get; set; }
//    public List<string> NIFTY { get; set; }
//    public List<string> GENERALI_X { get; set; }
//    public List<string> STOXBANK { get; set; }
//    public List<string> __invalid_name__BARC.L { get; set; }
//    public List<string> BMW_X { get; set; }
//    public List<string> SAP_X { get; set; }
//    public List<string> SX6E { get; set; }
//    public List<string> SXIP { get; set; }
//    public List<string> XIN50 { get; set; }
//    public List<string> __invalid_name__GSK.L { get; set; }
//    public List<string> NOKIA_X { get; set; }
//    public List<string> STOXENGY { get; set; }
//    public List<string> __invalid_name__ASML1.AS_X { get; set; }
//    public List<string> BASF_X { get; set; }
//    public List<string> CARREFOUR_X { get; set; }
//    public List<string> INTERBREW { get; set; }
//    public List<string> __invalid_name__SBID.IN { get; set; }
//    public List<string> __invalid_name__TLIT.MI { get; set; }
//    public List<string> SXAP { get; set; }
//    public List<string> VOLKSWAGEN_P_X { get; set; }
//    public List<string> __invalid_name__BLT.L { get; set; }
//    public List<string> __invalid_name__BRTI.IN { get; set; }
//    public List<string> EOE_X { get; set; }
//    public List<string> SX6P { get; set; }
//    public List<string> SX8P { get; set; }
//    public List<string> __invalid_name__ZURINS-NEW { get; set; }
//    public List<string> __invalid_name__3188.HK { get; set; }
//    public List<string> ABBLTD { get; set; }
//    public List<string> BNP_X { get; set; }
//    public List<string> __invalid_name__CNA.L { get; set; }
//    public List<string> __invalid_name__DEUT-POST { get; set; }
//    public List<string> __invalid_name__HSBA1.L { get; set; }
//    public List<string> __invalid_name__KUEHNE-NAGEL { get; set; }
//    public List<string> NDDUSG { get; set; }
//    public List<string> SXIE { get; set; }
//    public List<string> __invalid_name__UNC1.AS { get; set; }
//    public List<string> IBEX_X { get; set; }
//    public List<string> MXWO_NTR { get; set; }
//    public List<string> __invalid_name__REDY.IN { get; set; }
//    public List<string> SWISSCOM { get; set; }
//    public List<string> __invalid_name__TSCO.L { get; set; }
//    public List<string> __invalid_name__VSTXQ6-I { get; set; }
//    public List<string> __invalid_name__AAL.L { get; set; }
//    public List<string> AHOLD_X { get; set; }
//    public List<string> AXA_X { get; set; }
//    public List<string> M1EF { get; set; }
//    public List<string> __invalid_name__SANOFI-SYNTH { get; set; }
//    public List<string> __invalid_name__SHB-A { get; set; }
//    public List<string> STOXTCOM { get; set; }
//    public List<string> SXEE { get; set; }
//    public List<string> SXPP { get; set; }
//    public List<string> __invalid_name__TENR.MI { get; set; }
//    public List<string> ALLIANZ_X { get; set; }
//    public List<string> BBV2_X { get; set; }
//    public List<string> CSHOLDING { get; set; }
//    public List<string> EADS { get; set; }
//    public List<string> ENEL { get; set; }
//    public List<string> __invalid_name__ERICSSON-B { get; set; }
//    public List<string> __invalid_name__IMT.L { get; set; }
//    public List<string> SX86P { get; set; }
//    public List<string> __invalid_name__BATS.L { get; set; }
//    public List<string> __invalid_name__BAY.L { get; set; }
//    public List<string> ENI_X { get; set; }
//    public List<string> FTSE250 { get; set; }
//    public List<string> __invalid_name__GAZ.PA { get; set; }
//    public List<string> IBERDROLA_X { get; set; }
//    public List<string> __invalid_name__LLOY.L { get; set; }
//    public List<string> LVMH_X { get; set; }
//    public List<string> NORDHOLD { get; set; }
//    public List<string> __invalid_name__PSON.L { get; set; }
//    public List<string> RENAULT_X { get; set; }
//    public List<string> RWE_X { get; set; }
//    public List<string> __invalid_name__WOS.L { get; set; }
//    public List<string> __invalid_name__ANTO.L { get; set; }
//    public List<string> __invalid_name__BT.L { get; set; }
//    public List<string> DANONE_X { get; set; }
//    public List<string> __invalid_name__DGE.L { get; set; }
//    public List<string> FTE_X { get; set; }
//    public List<string> __invalid_name__HMB.ST { get; set; }
//    public List<string> __invalid_name__HOLZN.S { get; set; }
//    public List<object> __invalid_name__KEL.L { get; set; }
//    public List<string> LUFTHANSA_X { get; set; }
//    public List<string> MICHELIN_X { get; set; }
//    public List<string> NDDUPXJ { get; set; }
//    public List<string> __invalid_name__RDSB.L { get; set; }
//    public List<string> __invalid_name__RR.L { get; set; }
//    public List<string> SAGEM2 { get; set; }
//    public List<string> __invalid_name__SBRY.L { get; set; }
//    public List<string> __invalid_name__SHP.L { get; set; }
//    public List<string> SXKE { get; set; }
//    public List<object> BULGARI_X { get; set; }
//    public List<string> CONTI_X { get; set; }
//    public List<string> CREDIT_AGRICOLE { get; set; }
//    public List<string> __invalid_name__FSPA.ST { get; set; }
//    public List<string> __invalid_name__GKN.L { get; set; }
//    public List<string> __invalid_name__INVESTOR-B { get; set; }
//    public List<object> __invalid_name__LMI.L { get; set; }
//    public List<object> __invalid_name__LOG.L { get; set; }
//    public List<string> MXID { get; set; }
//    public List<string> NDDUNZ { get; set; }
//    public List<string> __invalid_name__NGG.L { get; set; }
//    public List<string> __invalid_name__RBOS.L { get; set; }
//    public List<string> __invalid_name__RSA1.L { get; set; }
//    public List<string> SCHNEIDER_X { get; set; }
//    public List<string> SCXP { get; set; }
//    public List<string> SD3E { get; set; }
//    public List<string> __invalid_name__SE-BANKEN-A { get; set; }
//    public List<string> __invalid_name__SN.L { get; set; }
//    public List<string> SX8E { get; set; }
//    public List<string> SXOP { get; set; }
//    public List<string> SXPE { get; set; }
//    public List<string> __invalid_name__UU.L { get; set; }
//    public List<string> VINCI { get; set; }
//    public List<string> __invalid_name__WTB.L { get; set; }
//    public List<string> __invalid_name__8306.T { get; set; }
//    public List<string> __invalid_name__8316.T/ BAJAJA.NS { get; set; }
//    public List<string> __invalid_name__AKZO1.AS_X { get; set; }
//    public List<object> __invalid_name__AL.L { get; set; }
//    public List<object> __invalid_name__ALBK.L { get; set; }
//    public List<object> __invalid_name__BB.L { get; set; }
//    public List<string> BELG { get; set; }
//    public List<string> __invalid_name__BPOST.BR { get; set; }
//    public List<string> __invalid_name__BRBY.L { get; set; }
//    public List<object> __invalid_name__BRT.L { get; set; }
//    public List<string> __invalid_name__CTG1.MC { get; set; }
//    public List<string> FRESENIUS_X { get; set; }
//    public List<string> GIVAUDAN { get; set; }
//    public List<string> __invalid_name__GLE-DES-EAUX_X { get; set; }
//    public List<object> __invalid_name__HBOS.L { get; set; }
//    public List<string> __invalid_name__IHG.L { get; set; }
//    public List<string> __invalid_name__INFOD.IN { get; set; }
//    public List<string> __invalid_name__ITV1.L { get; set; }
//    public List<string> __invalid_name__KINNEVIK-B { get; set; }
//    public List<string> __invalid_name__LGEN1.L { get; set; }
//    public List<object> __invalid_name__LII.L { get; set; }
//    public List<string> __invalid_name__LUPN.IN { get; set; }
//    public List<string> __invalid_name__MKS.L { get; set; }
//    public List<string> __invalid_name__M-RUECK_X { get; set; }
//    public List<object> __invalid_name__NRK.L { get; set; }
//    public List<string> __invalid_name__NXT.L { get; set; }
//    public List<string> PHONAK { get; set; }
//    public List<string> __invalid_name__POC.L { get; set; }
//    public List<string> __invalid_name__SAB.L { get; set; }
//    public List<string> SAIPEM_X { get; set; }
//    public List<string> __invalid_name__SGS-THOMSON-N_X { get; set; }
//    public List<string> __invalid_name__SIFI.MI_X { get; set; }
//    public List<object> __invalid_name__SL.L { get; set; }
//    public List<string> __invalid_name__SLOU.L { get; set; }
//    public List<string> __invalid_name__SSE.L { get; set; }
//    public List<string> __invalid_name__STM.MI { get; set; }
//    public List<string> STOX5_X { get; set; }
//    public List<string> __invalid_name__SVT.L { get; set; }
//    public List<string> SXDP { get; set; }
//    public List<string> SXMP { get; set; }
//    public List<string> SXNP { get; set; }
//    public List<string> TELIA { get; set; }
//    public List<string> TWII { get; set; }
//    public List<string> __invalid_name__UBSG.S { get; set; }
//    public List<string> UCB1 { get; set; }
//    public List<string> __invalid_name__ULVR1.L { get; set; }
//    public List<string> __invalid_name__05930.KS { get; set; }
//    public List<string> __invalid_name__2823.HK { get; set; }
//    public List<object> __invalid_name__4534.T { get; set; }
//    public List<object> __invalid_name__6651T { get; set; }
//    public List<object> __invalid_name__7942.T { get; set; }
//    public List<object> __invalid_name__8692.T { get; set; }
//    public List<string> ADIDAS_X { get; set; }
//    public List<object> __invalid_name__AGL.MI_X { get; set; }
//    public List<string> __invalid_name__AXFO.ST { get; set; }
//    public List<string> __invalid_name__BDEV.L { get; set; }
//    public List<object> __invalid_name__BOOT.L { get; set; }
//    public List<string> __invalid_name__BSY.L { get; set; }
//    public List<string> __invalid_name__CGNU.L { get; set; }
//    public List<string> COMMERZBANK_X { get; set; }
//    public List<string> __invalid_name__CPG.L { get; set; }
//    public List<object> __invalid_name__CW.L { get; set; }
//    public List<object> __invalid_name__DMGOA.L { get; set; }
//    public List<object> __invalid_name__DRX.L { get; set; }
//    public List<object> __invalid_name__DXNS.L { get; set; }
//    public List<string> __invalid_name__EMS-CHI { get; set; }
//    public List<object> __invalid_name__ETI.L { get; set; }
//    public List<string> __invalid_name__EXPN.L { get; set; }
//    public List<object> __invalid_name__FP.L { get; set; }
//    public List<string> __invalid_name__GFS.L { get; set; }
//    public List<string> __invalid_name__HEIDEL-Z_X { get; set; }
//    public List<string> __invalid_name__III.L { get; set; }
//    public List<string> __invalid_name__INF.L { get; set; }
//    public List<string> __invalid_name__ISPA.AS { get; set; }
//    public List<string> ITALCEMENTI_X { get; set; }
//    public List<string> __invalid_name__KGF.L { get; set; }
//    public List<string> MEDIOBANCA_X { get; set; }
//    public List<string> MITSUI_CORP { get; set; }
//    public List<string> __invalid_name__MODOB.ST { get; set; }
//    public List<string> __invalid_name__MONTE-D-PASCHI { get; set; }
//    public List<object> __invalid_name__MPI.L { get; set; }
//    public List<string> __invalid_name__MRW.L { get; set; }
//    public List<string> MXEF { get; set; }
//    public List<string> __invalid_name__PRU.L { get; set; }
//    public List<string> __invalid_name__RB.L { get; set; }
//    public List<string> __invalid_name__REED.L { get; set; }
//    public List<string> __invalid_name__SCH.MC { get; set; }
//    public List<string> __invalid_name__STAN.L { get; set; }
//    public List<object> __invalid_name__T4118-JPY { get; set; }
//    public List<string> TELEFONICA_X { get; set; }
//    public List<string> __invalid_name__TL5.MC { get; set; }
//    public List<object> __invalid_name__UNPI_P.MI { get; set; }
//    public List<string> __invalid_name__VSTXN7-I { get; set; }
//    public List<string> __invalid_name__VSTXQ7-I { get; set; }
//    public List<object> __invalid_name__XTA.L { get; set; }
//    public List<string> __invalid_name__0700.HK { get; set; }
//    public List<object> __invalid_name__2698.T { get; set; }
//    public List<object> __invalid_name__4008.T { get; set; }
//    public List<object> __invalid_name__4188.T { get; set; }
//    public List<object> __invalid_name__4216.T { get; set; }
//    public List<object> __invalid_name__4551T { get; set; }
//    public List<object> __invalid_name__4661.T { get; set; }
//    public List<object> __invalid_name__4779.T { get; set; }
//    public List<object> __invalid_name__5101.T { get; set; }
//    public List<object> __invalid_name__5480.T { get; set; }
//    public List<object> __invalid_name__6339.T { get; set; }
//    public List<object> __invalid_name__6345T { get; set; }
//    public List<object> __invalid_name__6471.T { get; set; }
//    public List<object> __invalid_name__6770T { get; set; }
//    public List<object> __invalid_name__6804.T { get; set; }
//    public List<object> __invalid_name__6976.T { get; set; }
//    public List<object> __invalid_name__6999.T { get; set; }
//    public List<object> __invalid_name__7459.T { get; set; }
//    public List<object> __invalid_name__7739.T { get; set; }
//    public List<object> __invalid_name__7905.T { get; set; }
//    public List<object> __invalid_name__7943.T { get; set; }
//    public List<object> __invalid_name__7947.T { get; set; }
//    public List<object> __invalid_name__8260.T { get; set; }
//    public List<object> __invalid_name__8333.T { get; set; }
//    public List<object> __invalid_name__8397.T { get; set; }
//    public List<object> __invalid_name__8439.T { get; set; }
//    public List<object> __invalid_name__8473.T { get; set; }
//    public List<object> __invalid_name__8568.T { get; set; }
//    public List<object> __invalid_name__8586.T { get; set; }
//    public List<object> __invalid_name__8868.T { get; set; }
//    public List<object> __invalid_name__92316 { get; set; }
//    public List<object> __invalid_name__9504.T { get; set; }
//    public List<object> __invalid_name__9511.T { get; set; }
//    public List<object> __invalid_name__9533.T { get; set; }
//    public List<object> __invalid_name__9619.T { get; set; }
//    public List<object> __invalid_name__9737.T { get; set; }
//    public List<string> __invalid_name__ABF.L { get; set; }
//    public List<string> __invalid_name__ALFA.ST { get; set; }
//    public List<object> __invalid_name__ARI.L { get; set; }
//    public List<string> __invalid_name__BLND.L { get; set; }
//    public List<string> __invalid_name__BNZL.L { get; set; }
//    public List<string> __invalid_name__BPCL.IN { get; set; }
//    public List<object> __invalid_name__CBRY1.L { get; set; }
//    public List<string> __invalid_name__CREDIT-NATION_X { get; set; }
//    public List<object> __invalid_name__CRH.L { get; set; }
//    public List<string> __invalid_name__CRH1.L { get; set; }
//    public List<string> DDAXK { get; set; }
//    public List<string> __invalid_name__ELECTROLUX-B { get; set; }
//    public List<object> __invalid_name__EMG.L { get; set; }
//    public List<object> __invalid_name__EMI.L { get; set; }
//    public List<string> __invalid_name__ENAG.MC { get; set; }
//    public List<string> ENDES1_X { get; set; }
//    public List<string> EPRA { get; set; }
//    public List<object> __invalid_name__FGP.L { get; set; }
//    public List<string> FIAT_X { get; set; }
//    public List<string> FTSE85 { get; set; }
//    public List<object> FUJITSU { get; set; }
//    public List<object> __invalid_name__GRFU.L { get; set; }
//    public List<string> __invalid_name__HAKN.ST { get; set; }
//    public List<string> __invalid_name__HCLT.IN { get; set; }
//    public List<string> __invalid_name__HEIN.AS-S_X { get; set; }
//    public List<object> __invalid_name__HG.L { get; set; }
//    public List<string> __invalid_name__HMSO.L { get; set; }
//    public List<object> __invalid_name__HNS.L { get; set; }
//    public List<string> __invalid_name__ICBK.IN { get; set; }
//    public List<object> __invalid_name__ICI.L { get; set; }
//    public List<object> __invalid_name__INCH1.L { get; set; }
//    public List<object> __invalid_name__ISYS.L { get; set; }
//    public List<string> __invalid_name__ITX.MC { get; set; }
//    public List<string> __invalid_name__JMAT.L { get; set; }
//    public List<object> __invalid_name__KAZ.L { get; set; }
//    public List<string> __invalid_name__KPN2.AS_X { get; set; }
//    public List<string> __invalid_name__LAND.L { get; set; }
//    public List<string> LCXP { get; set; }
//    public List<string> __invalid_name__LUX.MI { get; set; }
//    public List<string> M1EU { get; set; }
//    public List<object> __invalid_name__MAB.L { get; set; }
//    public List<string> MDAX_X { get; set; }
//    public List<string> MEDIASET_X { get; set; }
//    public List<string> MSDEE15N { get; set; }
//    public List<string> MSEAF { get; set; }
//    public List<string> __invalid_name__NCOMB.ST { get; set; }
//    public List<string> NDDUP { get; set; }
//    public List<object> NDX { get; set; }
//    public List<string> __invalid_name__NOVO-NORDISK-B { get; set; }
//    public List<string> __invalid_name__NUTCEM.IN { get; set; }
//    public List<object> OKUMA { get; set; }
//    public List<string> __invalid_name__OML.L { get; set; }
//    public List<string> PMI_X { get; set; }
//    public List<string> __invalid_name__RDSA.L { get; set; }
//    public List<string> __invalid_name__RICHEMONT-CIE-F { get; set; }
//    public List<string> __invalid_name__RTO.L { get; set; }
//    public List<object> __invalid_name__SCTN.L { get; set; }
//    public List<string> SDF_X { get; set; }
//    public List<object> __invalid_name__SDRT.L { get; set; }
//    public List<string> __invalid_name__SECUB.ST { get; set; }
//    public List<object> SEKISUI_H { get; set; }
//    public List<object> SHOWA_SHELL { get; set; }
//    public List<string> __invalid_name__SMIN.L { get; set; }
//    public List<string> __invalid_name__SRENH.VX { get; set; }
//    public List<object> SUMI_CORP { get; set; }
//    public List<string> SX3P { get; set; }
//    public List<string> SX4P { get; set; }
//    public List<string> SXFP { get; set; }
//    public List<string> SXHE { get; set; }
//    public List<object> __invalid_name__T2809-JPY { get; set; }
//    public List<object> __invalid_name__T4540-JPY { get; set; }
//    public List<object> __invalid_name__T6708-JPY { get; set; }
//    public List<object> __invalid_name__T7420-JPY { get; set; }
//    public List<object> __invalid_name__TATE.L { get; set; }
//    public List<string> __invalid_name__THYSSEN-KRUPP { get; set; }
//    public List<object> __invalid_name__TOMK.L { get; set; }
//    public List<object> __invalid_name__TPK.L { get; set; }
//    public List<string> __invalid_name__TWOD.L { get; set; }
//    public List<string> __invalid_name__UTBK.NS { get; set; }
//    public List<string> VALLOUREC_X { get; set; }
//    public List<string> __invalid_name__VOLVO-B { get; set; }
//    public List<string> __invalid_name__WPP.L { get; set; }
//    public List<object> YAMANOUCHI { get; set; }
//    public List<string> __invalid_name__YESB.BO { get; set; }
//    public List<string> __invalid_name__036490.KQ { get; set; }
//    public List<object> __invalid_name__1334.T { get; set; }
//    public List<object> __invalid_name__1792.T { get; set; }
//    public List<object> __invalid_name__1812.T { get; set; }
//    public List<object> __invalid_name__1868.T { get; set; }
//    public List<object> __invalid_name__1883.T { get; set; }
//    public List<object> __invalid_name__1884.T { get; set; }
//    public List<object> __invalid_name__1944.T { get; set; }
//    public List<object> __invalid_name__1945.T { get; set; }
//    public List<object> __invalid_name__1946.T { get; set; }
//    public List<object> __invalid_name__1949T { get; set; }
//    public List<object> __invalid_name__1968.T { get; set; }
//    public List<object> __invalid_name__1973.T { get; set; }
//    public List<object> __invalid_name__2002.T { get; set; }
//    public List<object> __invalid_name__2202.T { get; set; }
//    public List<object> __invalid_name__2261.T { get; set; }
//    public List<object> __invalid_name__2284.T { get; set; }
//    public List<object> __invalid_name__2286.T { get; set; }
//    public List<object> __invalid_name__2301.Q { get; set; }
//    public List<object> __invalid_name__2359.T { get; set; }
//    public List<object> __invalid_name__2502.T { get; set; }
//    public List<object> __invalid_name__2533.T { get; set; }
//    public List<object> __invalid_name__2607.T { get; set; }
//    public List<object> __invalid_name__2651.T { get; set; }
//    public List<object> __invalid_name__2715.T { get; set; }
//    public List<object> __invalid_name__2731.T { get; set; }
//    public List<object> __invalid_name__2768.T { get; set; }
//    public List<object> __invalid_name__2794.T { get; set; }
//    public List<object> __invalid_name__2875.T { get; set; }
//    public List<object> __invalid_name__2897.T { get; set; }
//    public List<object> __invalid_name__2910.T { get; set; }
//    public List<object> __invalid_name__3003.T { get; set; }
//    public List<object> __invalid_name__3050.T { get; set; }
//    public List<object> __invalid_name__3106.T { get; set; }
//    public List<object> __invalid_name__3107.T { get; set; }
//    public List<object> __invalid_name__3391.T { get; set; }
//    public List<object> __invalid_name__3401.T { get; set; }
//    public List<object> __invalid_name__3407.T { get; set; }
//    public List<string> __invalid_name__3474.TW { get; set; }
//    public List<object> __invalid_name__3591.T { get; set; }
//    public List<object> __invalid_name__3738.T { get; set; }
//    public List<object> __invalid_name__3893.T { get; set; }
//    public List<object> __invalid_name__4044.T { get; set; }
//    public List<object> __invalid_name__4088.T { get; set; }
//    public List<object> __invalid_name__4202.T { get; set; }
//    public List<object> __invalid_name__4217.T { get; set; }
//    public List<object> __invalid_name__4221.T { get; set; }
//    public List<object> __invalid_name__4307.T { get; set; }
//    public List<object> __invalid_name__4321.T { get; set; }
//    public List<object> __invalid_name__4324.T { get; set; }
//    public List<object> __invalid_name__4401.T { get; set; }
//    public List<object> __invalid_name__4410.T { get; set; }
//    public List<object> __invalid_name__4471.T { get; set; }
//    public List<object> __invalid_name__4516.T { get; set; }
//    public List<object> __invalid_name__4543.T { get; set; }
//    public List<object> __invalid_name__4613.T { get; set; }
//    public List<object> __invalid_name__4641.T { get; set; }
//    public List<object> __invalid_name__4681.T { get; set; }
//    public List<object> __invalid_name__4723.T { get; set; }
//    public List<object> __invalid_name__4732.T { get; set; }
//    public List<object> __invalid_name__4768.T { get; set; }
//    public List<object> __invalid_name__4812.T { get; set; }
//    public List<object> __invalid_name__5019.T { get; set; }
//    public List<object> __invalid_name__5208.T { get; set; }
//    public List<object> __invalid_name__5233.T { get; set; }
//    public List<object> __invalid_name__5269.T { get; set; }
//    public List<object> __invalid_name__5384.T { get; set; }
//    public List<object> __invalid_name__5405.T { get; set; }
//    public List<object> __invalid_name__5563.T { get; set; }
//    public List<object> __invalid_name__5602.T { get; set; }
//    public List<object> __invalid_name__5659T { get; set; }
//    public List<object> __invalid_name__5771.T { get; set; }
//    public List<object> __invalid_name__5809.T { get; set; }
//    public List<object> __invalid_name__5901.T { get; set; }
//    public List<object> __invalid_name__5936.T { get; set; }
//    public List<object> __invalid_name__5991.T { get; set; }
//    public List<object> __invalid_name__6104.T { get; set; }
//    public List<object> __invalid_name__6113T { get; set; }
//    public List<object> __invalid_name__6141.T { get; set; }
//    public List<object> __invalid_name__6274.T { get; set; }
//    public List<object> __invalid_name__6363.T { get; set; }
//    public List<object> __invalid_name__6369.T { get; set; }
//    public List<object> __invalid_name__6370.T { get; set; }
//    public List<object> __invalid_name__6371.T { get; set; }
//    public List<object> __invalid_name__6395.T { get; set; }
//    public List<object> __invalid_name__6407.T { get; set; }
//    public List<object> __invalid_name__6444.T { get; set; }
//    public List<object> __invalid_name__6448.T { get; set; }
//    public List<object> __invalid_name__6459.T { get; set; }
//    public List<object> __invalid_name__6462.T { get; set; }
//    public List<object> __invalid_name__6480.T { get; set; }
//    public List<object> __invalid_name__6581.T { get; set; }
//    public List<object> __invalid_name__6590.T { get; set; }
//    public List<object> __invalid_name__6674.T { get; set; }
//    public List<object> __invalid_name__6675.T { get; set; }
//    public List<object> __invalid_name__6704.T { get; set; }
//    public List<object> __invalid_name__6728.T { get; set; }
//    public List<object> __invalid_name__6741.T { get; set; }
//    public List<object> __invalid_name__6742.T { get; set; }
//    public List<object> __invalid_name__6749.T { get; set; }
//    public List<object> __invalid_name__6755.T { get; set; }
//    public List<object> __invalid_name__6756.T { get; set; }
//    public List<object> __invalid_name__6765.T { get; set; }
//    public List<object> __invalid_name__6768.T { get; set; }
//    public List<object> __invalid_name__6773.T { get; set; }
//    public List<object> __invalid_name__6806.T { get; set; }
//    public List<object> __invalid_name__6859.T { get; set; }
//    public List<object> __invalid_name__6915.T { get; set; }
//    public List<object> __invalid_name__6935.T { get; set; }
//    public List<object> __invalid_name__6965.T { get; set; }
//    public List<object> __invalid_name__6966.T { get; set; }
//    public List<object> __invalid_name__6996.T { get; set; }
//    public List<object> __invalid_name__7226T { get; set; }
//    public List<object> __invalid_name__7240.T { get; set; }
//    public List<object> __invalid_name__7261.T { get; set; }
//    public List<object> __invalid_name__7269.T { get; set; }
//    public List<object> __invalid_name__7276.T { get; set; }
//    public List<object> __invalid_name__7414.T { get; set; }
//    public List<object> __invalid_name__7483.T { get; set; }
//    public List<object> __invalid_name__7599.T { get; set; }
//    public List<object> __invalid_name__7608.T { get; set; }
//    public List<object> __invalid_name__7609.T { get; set; }
//    public List<object> __invalid_name__7729.T { get; set; }
//    public List<object> __invalid_name__7731.T { get; set; }
//    public List<object> __invalid_name__7832.T { get; set; }
//    public List<object> __invalid_name__7862.T { get; set; }
//    public List<object> __invalid_name__7952.T { get; set; }
//    public List<object> __invalid_name__8001.T { get; set; }
//    public List<object> __invalid_name__8012.T { get; set; }
//    public List<object> __invalid_name__8056.T { get; set; }
//    public List<object> __invalid_name__8058.T { get; set; }
//    public List<object> __invalid_name__8070T { get; set; }
//    public List<object> __invalid_name__8074.T { get; set; }
//    public List<object> __invalid_name__8133.T { get; set; }
//    public List<object> __invalid_name__8165.T { get; set; }
//    public List<object> __invalid_name__8168.T { get; set; }
//    public List<object> __invalid_name__8234.T { get; set; }
//    public List<object> __invalid_name__8276.T { get; set; }
//    public List<object> __invalid_name__8278.T { get; set; }
//    public List<object> __invalid_name__8303.T { get; set; }
//    public List<object> __invalid_name__8309.T { get; set; }
//    public List<object> __invalid_name__8327.T { get; set; }
//    public List<object> __invalid_name__8332.T { get; set; }
//    public List<object> __invalid_name__8339.T { get; set; }
//    public List<object> __invalid_name__8354.T { get; set; }
//    public List<object> __invalid_name__8374.T { get; set; }
//    public List<object> __invalid_name__8399.T { get; set; }
//    public List<object> __invalid_name__8415.T { get; set; }
//    public List<object> __invalid_name__8515.T { get; set; }
//    public List<object> __invalid_name__8519.T { get; set; }
//    public List<object> __invalid_name__8527T { get; set; }
//    public List<object> __invalid_name__8550.T { get; set; }
//    public List<object> __invalid_name__8562T { get; set; }
//    public List<object> __invalid_name__8573.T { get; set; }
//    public List<object> __invalid_name__8579.T { get; set; }
//    public List<object> __invalid_name__8595.T { get; set; }
//    public List<object> __invalid_name__8606.T { get; set; }
//    public List<object> __invalid_name__8616.T { get; set; }
//    public List<object> __invalid_name__8759.T { get; set; }
//    public List<object> __invalid_name__8766.T { get; set; }
//    public List<object> __invalid_name__8830.T { get; set; }
//    public List<object> __invalid_name__8877.T { get; set; }
//    public List<object> __invalid_name__9070.T { get; set; }
//    public List<object> __invalid_name__9110.T { get; set; }
//    public List<object> __invalid_name__9113.T { get; set; }
//    public List<object> __invalid_name__9132.T { get; set; }
//    public List<object> __invalid_name__9305.T { get; set; }
//    public List<object> __invalid_name__9364.T { get; set; }
//    public List<object> __invalid_name__9375.T { get; set; }
//    public List<object> __invalid_name__9409.T { get; set; }
//    public List<object> __invalid_name__9502.T { get; set; }
//    public List<object> __invalid_name__9503.T { get; set; }
//    public List<object> __invalid_name__9509.T { get; set; }
//    public List<object> __invalid_name__9531.T { get; set; }
//    public List<object> __invalid_name__9607.T { get; set; }
//    public List<object> __invalid_name__9616.T { get; set; }
//    public List<object> __invalid_name__9697.T { get; set; }
//    public List<object> __invalid_name__9742.T { get; set; }
//    public List<object> __invalid_name__9749.T { get; set; }
//    public List<object> __invalid_name__9783.T { get; set; }
//    public List<object> __invalid_name__9790.T { get; set; }
//    public List<object> __invalid_name__9831.T { get; set; }
//    public List<object> __invalid_name__9843.T { get; set; }
//    public List<object> __invalid_name__9854.T { get; set; }
//    public List<object> __invalid_name__9916T { get; set; }
//    public List<object> __invalid_name__9956.T { get; set; }
//    public List<object> __invalid_name__9984.T { get; set; }
//    public List<object> __invalid_name__9997.T { get; set; }
//    public List<object> __invalid_name__ABN.AS_X { get; set; }
//    public List<string> __invalid_name__ABN-W.AS { get; set; }
//    public List<string> __invalid_name__ADM.L { get; set; }
//    public List<string> __invalid_name__AEM-SPA_X { get; set; }
//    public List<object> __invalid_name__AGA.L { get; set; }
//    public List<object> __invalid_name__AGS.L { get; set; }
//    public List<string> __invalid_name__AHT.L { get; set; }
//    public List<string> __invalid_name__AIR-LIQUIDE_X { get; set; }
//    public List<object> ALSTOM_NEW { get; set; }
//    public List<object> __invalid_name__AML.L { get; set; }
//    public List<string> __invalid_name__ANHA.L { get; set; }
//    public List<string> __invalid_name__ANIM.MI { get; set; }
//    public List<string> __invalid_name__ANZ.AX { get; set; }
//    public List<object> __invalid_name__ARM.L { get; set; }
//    public List<object> ASAHI_GLASS { get; set; }
//    public List<string> AUTOSTRADE_X { get; set; }
//    public List<object> __invalid_name__AVZ.L { get; set; }
//    public List<string> __invalid_name__AZMT.MI { get; set; }
//    public List<object> __invalid_name__AZPIA.MI_X { get; set; }
//    public List<string> __invalid_name__BA.L { get; set; }
//    public List<string> __invalid_name__BAB.L { get; set; }
//    public List<string> __invalid_name__BAJAJA.NS { get; set; }
//    public List<object> __invalid_name__BBY.L { get; set; }
//    public List<string> __invalid_name__BKIA.MC { get; set; }
//    public List<object> BLUECHIP { get; set; }
//    public List<string> __invalid_name__BP.MI { get; set; }
//    public List<string> __invalid_name__BPU.MI { get; set; }
//    public List<object> __invalid_name__BWY.L { get; set; }
//    public List<object> __invalid_name__BXTN.L { get; set; }
//    public List<string> __invalid_name__BZU.MI { get; set; }
//    public List<object> C_SAISON { get; set; }
//    public List<object> CANON { get; set; }
//    public List<string> __invalid_name__CCH.LN { get; set; }
//    public List<object> __invalid_name__CCR.L { get; set; }
//    public List<object> __invalid_name__CNE.L { get; set; }
//    public List<string> __invalid_name__CNHI.IM { get; set; }
//    public List<object> __invalid_name__CPI.L { get; set; }
//    public List<string> __invalid_name__CPR.MI { get; set; }
//    public List<object> __invalid_name__CPW.L { get; set; }
//    public List<string> __invalid_name__CRDA.L { get; set; }
//    public List<string> __invalid_name__CRIT.MC { get; set; }
//    public List<string> __invalid_name__CTEC.L { get; set; }
//    public List<object> __invalid_name__CTT.L { get; set; }
//    public List<object> DAIDO_STEEL { get; set; }
//    public List<object> __invalid_name__DCC.L { get; set; }
//    public List<string> __invalid_name__DCC.L2 { get; set; }
//    public List<string> DELHAIZE_X { get; set; }
//    public List<string> __invalid_name__DLGD.L { get; set; }
//    public List<object> __invalid_name__DNLM.L { get; set; }
//    public List<object> DNP_SCREEN { get; set; }
//    public List<object> __invalid_name__DSCT.TA { get; set; }
//    public List<object> __invalid_name__DWV.L { get; set; }
//    public List<object> __invalid_name__ECM.L { get; set; }
//    public List<string> __invalid_name__EGPW.MI { get; set; }
//    public List<object> __invalid_name__ELN.L { get; set; }
//    public List<string> __invalid_name__EMII.MI { get; set; }
//    public List<object> __invalid_name__ENO.L { get; set; }
//    public List<string> __invalid_name__E-ON { get; set; }
//    public List<string> ESSILOR_X { get; set; }
//    public List<string> __invalid_name__EXOR.IM { get; set; }
//    public List<string> __invalid_name__EZJ.L { get; set; }
//    public List<object> __invalid_name__FORTIS-NV1 { get; set; }
//    public List<object> __invalid_name__FPT.L { get; set; }
//    public List<string> __invalid_name__FRES.L { get; set; }
//    public List<object> __invalid_name__FROTO.IS { get; set; }
//    public List<object> __invalid_name__GOL.OL { get; set; }
//    public List<object> __invalid_name__GYG.L { get; set; }
//    public List<object> __invalid_name__HHG.L { get; set; }
//    public List<string> __invalid_name__HL.L { get; set; }
//    public List<object> HOKUETSU { get; set; }
//    public List<string> HONDA { get; set; }
//    public List<object> __invalid_name__HOT.N { get; set; }
//    public List<object> __invalid_name__HSV.L { get; set; }
//    public List<object> __invalid_name__IAW.L { get; set; }
//    public List<object> IBIDEN { get; set; }
//    public List<object> __invalid_name__ICP.L { get; set; }
//    public List<object> __invalid_name__INTESA-RNC_X { get; set; }
//    public List<object> __invalid_name__INVP.L { get; set; }
//    public List<object> __invalid_name__IPM.L { get; set; }
//    public List<object> __invalid_name__IPO.L { get; set; }
//    public List<object> __invalid_name__ISAT.L { get; set; }
//    public List<string> __invalid_name__ITRK.L { get; set; }
//    public List<object> JR_WEST { get; set; }
//    public List<object> JUSCO { get; set; }
//    public List<object> __invalid_name__KIE.L { get; set; }
//    public List<object> KIKKOMAN { get; set; }
//    public List<object> KISSEI_P { get; set; }
//    public List<object> KOYO_SEIKO { get; set; }
//    public List<object> __invalid_name__LOIM.PA_X { get; set; }
//    public List<string> LOREAL_X { get; set; }
//    public List<string> __invalid_name__LSE.L { get; set; }
//    public List<object> MATSUMOTO_K { get; set; }
//    public List<string> __invalid_name__MCRO.L { get; set; }
//    public List<string> __invalid_name__MEDIOLANUM-N_X { get; set; }
//    public List<string> __invalid_name__MERL.L { get; set; }
//    public List<object> METRO_X { get; set; }
//    public List<object> __invalid_name__MFI.L { get; set; }
//    public List<object> __invalid_name__MGCR.L { get; set; }
//    public List<object> __invalid_name__MGGT.L { get; set; }
//    public List<object> MITSUI_PETRO_LB { get; set; }
//    public List<string> __invalid_name__MNDI.L { get; set; }
//    public List<object> __invalid_name__MNDI.MI_X { get; set; }
//    public List<string> __invalid_name__MONC.MI { get; set; }
//    public List<object> MORINAGA_MILK { get; set; }
//    public List<object> MTB_HEAVY { get; set; }
//    public List<object> MU { get; set; }
//    public List<object> NATIONAL_H { get; set; }
//    public List<string> NDDUHK { get; set; }
//    public List<object> NGK_SPARK { get; set; }
//    public List<object> NIP_ELEC { get; set; }
//    public List<object> NIP_STEEL { get; set; }
//    public List<object> NIP_YUSEN { get; set; }
//    public List<object> NISSAN { get; set; }
//    public List<object> NISSHIN_OIL { get; set; }
//    public List<string> __invalid_name__NN.AS { get; set; }
//    public List<object> NSC { get; set; }
//    public List<object> OJI_PAPER { get; set; }
//    public List<object> ONWARD { get; set; }
//    public List<object> __invalid_name__PECI.MI_X { get; set; }
//    public List<object> __invalid_name__PFD.L { get; set; }
//    public List<string> __invalid_name__PFG.L { get; set; }
//    public List<string> __invalid_name__PHG1.AS { get; set; }
//    public List<object> __invalid_name__PMO.L { get; set; }
//    public List<string> __invalid_name__PPB.L { get; set; }
//    public List<object> PREUSSAG_X { get; set; }
//    public List<string> __invalid_name__PRY.MI { get; set; }
//    public List<string> __invalid_name__PSN.L { get; set; }
//    public List<string> __invalid_name__PST.IM { get; set; }
//    public List<object> __invalid_name__PUB.L { get; set; }
//    public List<string> __invalid_name__RAC.MI { get; set; }
//    public List<string> __invalid_name__RMGLN.L { get; set; }
//    public List<string> __invalid_name__RRS.L { get; set; }
//    public List<object> __invalid_name__RTA.L { get; set; }
//    public List<object> __invalid_name__RTR.L { get; set; }
//    public List<object> __invalid_name__RYAN.L { get; set; }
//    public List<string> SAI_X { get; set; }
//    public List<string> __invalid_name__SAINT-GOBAIN_X { get; set; }
//    public List<object> SAN_AI_OIL { get; set; }
//    public List<object> SANWA_SHUT { get; set; }
//    public List<string> __invalid_name__SDR.L { get; set; }
//    public List<string> __invalid_name__SEV.AX { get; set; }
//    public List<string> __invalid_name__SFER.MI { get; set; }
//    public List<string> __invalid_name__SGE.L { get; set; }
//    public List<object> SHOWA_ELEC { get; set; }
//    public List<object> __invalid_name__SIG.L { get; set; }
//    public List<string> __invalid_name__SKFB.ST { get; set; }
//    public List<string> __invalid_name__SKG.GBP { get; set; }
//    public List<string> __invalid_name__SMT.L { get; set; }
//    public List<object> __invalid_name__SPT.L { get; set; }
//    public List<string> __invalid_name__SRG.MI { get; set; }
//    public List<string> __invalid_name__STJ.L { get; set; }
//    public List<object> SUMI_BAKELITE { get; set; }
//    public List<object> SUMI_CEMENT { get; set; }
//    public List<object> SUMI_RUBBER { get; set; }
//    public List<string> __invalid_name__SUND.IN { get; set; }
//    public List<object> __invalid_name__T4521-JPY { get; set; }
//    public List<object> __invalid_name__T5706-JPY { get; set; }
//    public List<object> __invalid_name__T7280-JPY { get; set; }
//    public List<object> TAISEI { get; set; }
//    public List<object> __invalid_name__TLITN.MI { get; set; }
//    public List<object> __invalid_name__TLW.L { get; set; }
//    public List<object> __invalid_name__TNI.L { get; set; }
//    public List<string> __invalid_name__TNTE.AS { get; set; }
//    public List<string> __invalid_name__TOD.MI { get; set; }
//    public List<object> TOKYO_DOME { get; set; }
//    public List<object> TOKYO_PWR { get; set; }
//    public List<object> TOPPAN_PRT { get; set; }
//    public List<object> TOTO { get; set; }
//    public List<object> TOYOTA { get; set; }
//    public List<object> TOYOTA_AUTO { get; set; }
//    public List<string> __invalid_name__TUI.LN { get; set; }
//    public List<object> __invalid_name__UBM.L { get; set; }
//    public List<string> __invalid_name__UNBP1.AS { get; set; }
//    public List<string> UNIPOL_X { get; set; }
//    public List<object> __invalid_name__V.MI { get; set; }
//    public List<object> __invalid_name__VED.L { get; set; }
//    public List<object> VIE { get; set; }
//    public List<object> __invalid_name__WEIR.L { get; set; }
//    public List<object> __invalid_name__WIN.L { get; set; }
//    public List<object> __invalid_name__WMH.L { get; set; }
//    public List<object> __invalid_name__WNER.L { get; set; }
//    public List<string> __invalid_name__WPG.L { get; set; }
//    public List<object> YAMAHA { get; set; }
//    public List<object> YAMAHA_MO { get; set; }
//    public List<object> YAMATAKE_H { get; set; }
//    public List<object> __invalid_name__YELL.L { get; set; }
//    public List<string> __invalid_name__YOOX.MI { get; set; }
//    public List<string> ZOLL { get; set; }
//    public List<object> ZUKEN { get; set; }
//    public List<string> __invalid_name__0489.HK { get; set; }
//    public List<string> __invalid_name__8383.T { get; set; }
//    public List<string> __invalid_name__8876.T { get; set; }
//    public List<string> __invalid_name__8905.T { get; set; }
//    public List<string> __invalid_name__09830.KS { get; set; }
//    public List<string> __invalid_name__09150.KS { get; set; }
//    public List<string> __invalid_name__0941.HK { get; set; }
//    public List<string> __invalid_name__2202.HK { get; set; }
//    public List<string> __invalid_name__3323.HK { get; set; }
//    public List<string> __invalid_name__635483 { get; set; }
//    public List<string> __invalid_name__ILU.AX { get; set; }
//    public List<string> __invalid_name__06800.KS { get; set; }
//    public List<string> __invalid_name__0267.HK { get; set; }
//    public List<string> __invalid_name__1339.HK { get; set; }
//    public List<string> __invalid_name__2628.HK { get; set; }
//    public List<string> __invalid_name__CONW.VI { get; set; }
//    public List<string> __invalid_name__00210.KS { get; set; }
//    public List<string> __invalid_name__RDS.AS { get; set; }
//    public List<string> __invalid_name__011070.KS { get; set; }
//    public List<string> __invalid_name__138930.KS { get; set; }
//    public List<string> __invalid_name__55550.KS { get; set; }
//    public List<string> EWY { get; set; }
//}
   

    public class RootObjectValues
    {
        public OPTIONTYPE OPTION_TYPE { get; set; }
        public CURRENCY CURRENCY { get; set; }
        public BROKERFEESCCY BROKER_FEES_CCY { get; set; }
        public BUYSELL BUY_SELL { get; set; }
        public Object UNDERLYING_NAME { get; set; }
    }
}
