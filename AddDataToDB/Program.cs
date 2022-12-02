using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EESV2.AddDataToDB.Models;
using EESV2.DAL;
using EESV2.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EESV2.AddDataToDB
{
    class Program
    {

        public static OldDBContext oldDBContext = new OldDBContext();
        static void Main(string[] args)
        {
            #region 
            var tbl0 = oldDBContext.TblSemats.ToList();
            foreach (var o in tbl0)
            {
                try
                {
                    EESContext newDBContext = new EESContext();
                    Office of = new Office()
                    {
                        ID = o.Ids,
                        Name = o.Semat,
                        ParrentOfficeID = o.Idup
                    };
                    newDBContext.Offices.Add(of);
                    newDBContext.Database.OpenConnection();
                    try
                    {
                        newDBContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Offices ON");
                        newDBContext.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        newDBContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Offices OFF");
                        newDBContext.Database.CloseConnection();
                    }
                }
                catch (Exception)
                {
                }
            }
            #endregion

            #region 
            List<TblUsr> tbl1 = oldDBContext.TblUsrs.ToList();
            foreach (var o in tbl1)
            {
                try
                {
                    EESContext newDBContext = new EESContext();
                    var of = new User()
                    {
                        ID = Convert.ToInt32(o.Username),
                        Username = o.Username,
                        Password = o.Password,
                        FirstName = o.Fname,
                        LastName = o.Lname,
                        AddressHome = o.AddressHome,
                        CreateDate = o.CreateDate,
                        HomePhone = o.HomePhone,
                        Mobile = o.Mobile,
                        OfficeID = (o.UnitId!=null?(int)o.UnitId:1),
                        Pic = o.Pic,
                        StatusID = 1,
                        EmploymentTypeID=1,
                        PortalMembershipTypeID=1,
                        PostID=1,
                        WorkPhone = o.WorkPhone,

                    };
                    newDBContext.Users.Add(of);
                    newDBContext.Database.OpenConnection();
                    try
                    {
                        newDBContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Users ON");
                        newDBContext.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        newDBContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Users OFF");
                        newDBContext.Database.CloseConnection();
                    }
                }
                catch (Exception)
                {
                }
            }
            #endregion

            #region
            List<TblProp> tbl2 = oldDBContext.TblProps.ToList();
            foreach (var o in tbl2)
            {
                try
                {
                    EESContext newDBContext = new EESContext();
                    var of = new Proposal();
                    if (o.Ch01 == null) of.Ch01 = false; else of.Ch01 = (bool)o.Ch01;
                    if (o.Ch02 == null) of.Ch02 = false; else of.Ch02 = (bool)o.Ch02;
                    if (o.Ch03 == null) of.Ch03 = false; else of.Ch03 = (bool)o.Ch03;
                    if (o.Ch04 == null) of.Ch04 = false; else of.Ch04 = (bool)o.Ch04;
                    if (o.Ch05 == null) of.Ch05 = false; else of.Ch05 = (bool)o.Ch05;
                    if (o.Ch06 == null) of.Ch06 = false; else of.Ch06 = (bool)o.Ch06;
                    if (o.Ch07 == null) of.Ch07 = false; else of.Ch07 = (bool)o.Ch07;
                    if (o.Ch08 == null) of.Ch08 = false; else of.Ch08 = (bool)o.Ch08;
                    if (o.Ch09 == null) of.Ch09 = false; else of.Ch09 = (bool)o.Ch09;
                    if (o.Ch10 == null) of.Ch10 = false; else of.Ch10 = (bool)o.Ch10;
                    if (o.Ch11 == null) of.Ch11 = false; else of.Ch11 = (bool)o.Ch11;
                    if (o.Ch12 == null) of.Ch12 = false; else of.Ch12 = (bool)o.Ch12;
                    if (o.Ch13 == null) of.Ch13 = false; else of.Ch13 = (bool)o.Ch13;
                    if (o.Ch14 == null) of.Ch14 = false; else of.Ch14 = (bool)o.Ch14;
                    if (o.Ch15 == null) of.Ch15 = false; else of.Ch15 = (bool)o.Ch15;
                    if (o.Ch16 == null) of.Ch16 = false; else of.Ch16 = (bool)o.Ch16;
                    if (o.Ch17 == null) of.Ch17 = false; else of.Ch17 = (bool)o.Ch17;
                    if (o.Ch18 == null) of.Ch18 = false; else of.Ch18 = (bool)o.Ch18;
                    if (o.Ch19 == null) of.Ch19 = false; else of.Ch19 = (bool)o.Ch19;
                    if (o.Ch20 == null) of.Ch20 = false; else of.Ch20 = (bool)o.Ch20;
                    if (o.Ch21 == null) of.Ch21 = false; else of.Ch21 = (bool)o.Ch21;
                    if (o.Ch22 == null) of.Ch22 = false; else of.Ch22 = (bool)o.Ch22;
                    if (o.Ch23 == null) of.Ch23 = false; else of.Ch23 = (bool)o.Ch23;
                    if (o.Ch24 == null) of.Ch24 = false; else of.Ch24 = (bool)o.Ch24;
                    if (o.Ch25 == null) of.Ch25 = false; else of.Ch25 = (bool)o.Ch25;
                    if (o.Ch26 == null) of.Ch26 = false; else of.Ch26 = (bool)o.Ch26;
                    if (o.Ch27 == null) of.Ch27 = false; else of.Ch27 = (bool)o.Ch27;
                    if (o.Ch28 == null) of.Ch28 = false; else of.Ch28 = (bool)o.Ch28;
                    if (o.Ch29 == null) of.Ch29 = false; else of.Ch29 = (bool)o.Ch29;
                    if (o.Ch30 == null) of.Ch30 = false; else of.Ch30 = (bool)o.Ch30;
                    if (o.Ch31 == null) of.Ch31 = false; else of.Ch31 = (bool)o.Ch31;
                    if (o.Ch32 == null) of.Ch32 = false; else of.Ch31 = (bool)o.Ch32;
                    if (o.Ch33 == null) of.Ch33 = false; else of.Ch33 = (bool)o.Ch33;
                    if (o.Ch34 == null) of.Ch34 = false; else of.Ch34 = (bool)o.Ch34;
                    if (o.Ch35 == null) of.Ch35 = false; else of.Ch35 = (bool)o.Ch35;
                    if (o.Ch36 == null) of.Ch36 = false; else of.Ch36 = (bool)o.Ch36;
                    if (o.Ch37 == null) of.Ch37 = false; else of.Ch37 = (bool)o.Ch37;
                    of.CodeBazr = o.CodeBazr;
                    of.CurrentDescPr = o.CurrentDescPr;
                    of.Date = o.DateN;
                    of.DesDabir = o.DesDabir;
                    of.Ejra5Year = (o.Ejra5Year!=null?o.Ejra5Year.ToString():"0");
                    of.EjraYear = (o.EjraYear != null ? o.EjraYear.ToString() : "0");
                    of.EjraMonthly = (o.EjraMonthly != null ? o.EjraMonthly.ToString() : "0");
                    of.EjraDaily = (o.EjraDaily != null ? o.EjraDaily.ToString() : "0");
                    of.Sarfe5Year = (o.Sarfe5Year != null ? o.Sarfe5Year.ToString() : "0");
                    of.SarfeYear = (o.SarfeYear != null ? o.SarfeYear.ToString() : "0");
                    of.SarfeMonthly = (o.SarfeMonthly != null ? o.SarfeMonthly.ToString() : "0");
                    of.SarfeDaily = (o.SarfeDaily != null ? o.SarfeDaily.ToString() : "0");
                    of.Get5Year = (o.Get5Year != null ? o.Get5Year.ToString() : "0");
                    of.GetYear = (o.GetYear != null ? o.GetYear.ToString() : "0");
                    of.GetMonthly = (o.GetMonthly != null ? o.GetMonthly.ToString() : "0");
                    of.Time = o.TimeN;
                    of.SubjectPr = o.SubjectPr;
                    of.StatusID = o.StatusId!=null?(int)o.StatusId:7;
                    of.RegistrarParticipatePercent = 100;
                    of.RegistrarID =Convert.ToInt32(o.Usrid);
                    of.NewDesPr = o.NewDesPr;
                    of.File = o.AtF;
                    of.ID = o.Idpr;
                    newDBContext.proposals.Add(of);
                    newDBContext.Database.OpenConnection();
                    try
                    {
                        newDBContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Proposals ON");
                        newDBContext.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        newDBContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Proposals OFF");
                        newDBContext.Database.CloseConnection();
                    }
                }
                catch (Exception ex)
                {
                }
            }

            #endregion
            #region
            
            var tbl3 = (from t1 in oldDBContext.TblErjas
                       join t2 in oldDBContext.TblArzyabs on t1.ArzyabIdSrc equals t2.ArzyabId
                       join t3 in oldDBContext.TblUsrs on t2.EmNo equals t3.EmP
                       join t4 in oldDBContext.TblArzyabs on t1.ArzyabIdDes equals t4.ArzyabId
                       join t5 in oldDBContext.TblUsrs on t4.EmNo equals t5.EmP
                       select new {t1,t2,t3,t4,t5 }).ToList();

            foreach (var o in tbl3)
            {
                try
                {
                    EESContext newDBContext = new EESContext();
                    var of = new Referral
                    {
                        ID = o.t1.ErjaId,
                        Date = o.t1.Tarikh,
                        Description = o.t1.Description,
                        IP = o.t1.Ip,
                        ProposalID = (int)o.t1.Idpr,
                        MeetingNo = o.t1.JalaseNo,
                        SenderID = Convert.ToInt32(o.t3.EmP),
                        ReciverID = Convert.ToInt32(o.t5.EmP),
                        Time = o.t1.SaAt,
                        StatusID=2,
                        Result="",
                        EvaluationTypeID=3
                    };
                    newDBContext.Referrals.Add(of);
                    newDBContext.Database.OpenConnection();
                    try
                    {
                        newDBContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Referrals ON");
                        newDBContext.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        newDBContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Referrals OFF");
                        newDBContext.Database.CloseConnection();
                    }
                }
                catch (Exception ex)
                {
                }
            }
            
            #endregion

            #region
            
            var tbl4 = oldDBContext.TblEblaghs.ToList();

            foreach (var o in tbl4)
            {
                try
                {
                    EESContext newDBContext = new EESContext();
                    var of = new Impart
                    {
                        ID = o.EblaghId,
                        Cost=o.Hazineh,
                        Date=o.Tarikh,
                        Time=o.Saat,
                        DescriptionExecute=o.SharhEjrai,
                        StartDateExecute=o.DateStart,
                        EndDateExecute=o.DateEnd,
                        ExecutorID=Convert.ToInt32(o.EmNoEblagh),
                        ExecutorIP=o.Ipba,
                        ExecutorRegistrationDate=o.TarikhBa,
                        ExecutorRegistrationTime=o.SaatBa,
                        ImpartStatusID=Convert.ToInt32(o.IntOk)+1,
                        ProposalID=(int)o.Idpr,
                        TimeToExecute=o.Long,
                        
                    };
                    newDBContext.Imparts.Add(of);
                    newDBContext.Database.OpenConnection();
                    try
                    {
                        newDBContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Imparts ON");
                        newDBContext.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        newDBContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Imparts OFF");
                        newDBContext.Database.CloseConnection();
                    }
                }
                catch (Exception ex)
                {
                }
            }
            
            #endregion
            #region
            
            var tbl5 = oldDBContext.TblEblaghHamkars.ToList();

            foreach (var o in tbl5)
            {
                try
                {
                    EESContext newDBContext = new EESContext();
                    var of = new UserImpart
                    {
                        ID = o.HamkarId,
                        ImpartID = (int)o.EblaghId,
                        UserID = Convert.ToInt32(o.EmNo)
                    };
                    newDBContext.UserImparts.Add(of);
                    newDBContext.Database.OpenConnection();
                    try
                    {
                        newDBContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.UserImparts ON");
                        newDBContext.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        newDBContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.UserImparts OFF");
                        newDBContext.Database.CloseConnection();
                    }
                }
                catch (Exception ex)
                {
                }
            }
            
            #endregion
            #region
            
            var tbl6 = oldDBContext.TblEblaghReps.ToList();

            foreach (var o in tbl6)
            {
                try
                {
                    EESContext newDBContext = new EESContext();
                    var of = new ProgressReport
                    {
                        ID=o.IdeblaghRep,
                        Date=o.Tarikh,
                        Defects=o.DescNavaghes,
                        Description=o.DescRep,
                        File=o.AttachFile,
                        ImpartID=(int)o.EblaghId,
                        IP=o.Ip,
                        Percentage=(int)o.Darsad
                    };
                    newDBContext.ProgressReports.Add(of);
                    newDBContext.Database.OpenConnection();
                    try
                    {
                        newDBContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.ProgressReports ON");
                        newDBContext.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        newDBContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.ProgressReports OFF");
                        newDBContext.Database.CloseConnection();
                    }
                }
                catch (Exception ex)
                {
                }
            }
            
            #endregion

            #region
            
            var tbl7 = oldDBContext.TblArzyabis.ToList();

            foreach (var o in tbl7)
            {
                try
                {
                    EESContext newDBContext = new EESContext();
                    if (o.Q1!=null)//فرم کمی است
                    {
                        var of = new QuantitativEvaluation
                        {
                            ID = o.ArzyabiId,
                            DateArz=o.DateArz,
                            Ejra5Year=o.Ejra5Year,
                            Q1=o.Q1,
                            EjraMonth=o.EjraMonth,
                            EjraYear=o.EjraYear,
                            ErjraDaily=o.ErjraDaily,
                            HrWork=o.HrWork,
                            MablaghNahaiAlphabet=o.MablaghNahaiAlphabet,
                            MablaghNahaiNumber=o.MablaghNahaiNumber,
                            PishOk=o.PishOk,
                            Q10=o.Q10,
                            Q2=o.Q2,
                            Q3=o.Q3,
                            Q4=o.Q4,
                            Q5=o.Q5,
                            Q6 = o.Q6,
                            Q7=o.Q7,
                            Q8=o.Q8,
                            Q9=o.Q9,
                            ReferralID=o.ErjaId,
                            Sama5Year=o.Sama5Year,
                            SamarDaily=o.SamarDaily,
                            SamarMonth=o.SamarMonth,
                            SamarYear=o.SamarYear,
                            Sarfe5Year=o.Sarfe5Year,
                            SarfeDaily=o.SarfeDaily,
                            SarfeMonth=o.SarfeMonth,
                            SarfeYear=o.SarfeYear
                        };
                        newDBContext.QuantitativEvaluations.Add(of);
                        newDBContext.Database.OpenConnection();
                        try
                        {
                            newDBContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.QuantitativEvaluations ON");
                            newDBContext.SaveChanges();
                            Referral referral = newDBContext.Referrals.SingleOrDefault(r => r.ID == o.ErjaId);
                            referral.EvaluationTypeID = 1;
                            newDBContext.Entry(referral).State = EntityState.Modified;
                            newDBContext.SaveChanges();
                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {
                            newDBContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.QuantitativEvaluations OFF");
                            newDBContext.Database.CloseConnection();
                        }
                    }
                    else//فرم کیفی است
                    {
                        var of = new QualityEvaluation
                        {
                            ID = o.ArzyabiId,
                            HrWork = o.HrWork,
                            ReferralID = o.ErjaId,
                            K1=o.K1,
                            K2=o.K2,
                            K3=o.K3,
                            K4=o.K4,
                            K5=o.K5,
                            K6=o.K6,
                            K7=o.K7,
                            K8=o.K8,
                            PishOk=o.PishOk,
                            RejectReason=""
                        };
                        newDBContext.QualityEvaluations.Add(of);
                        newDBContext.Database.OpenConnection();
                        try
                        {
                            newDBContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.QualityEvaluations ON");
                            newDBContext.SaveChanges();
                            Referral referral = newDBContext.Referrals.SingleOrDefault(r => r.ID == o.ErjaId);
                            referral.EvaluationTypeID = 2;
                            newDBContext.Entry(referral).State = EntityState.Modified;
                            newDBContext.SaveChanges();
                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {
                            newDBContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.QualityEvaluations OFF");
                            newDBContext.Database.CloseConnection();
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
            
            #endregion

            #region
            
            var tbl8 = oldDBContext.TblProtests.ToList();

            foreach (var o in tbl8)
            {
                try
                {
                    EESContext newDBContext = new EESContext();
                    var of = new Objection
                    {
                        ID=o.Idprotest,
                        Date=o.Tarikh,
                        Time=o.Saat,
                        IP="",
                        ProposalID=(int)o.Idpr,
                        UserID=Convert.ToInt32(o.Emno),
                        Reasons=o.Descr,
                        Result=o.Answ,
                    };
                    newDBContext.Objections.Add(of);
                    newDBContext.Database.OpenConnection();
                    try
                    {
                        newDBContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Objections ON");
                        newDBContext.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        newDBContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Objections OFF");
                        newDBContext.Database.CloseConnection();
                    }
                }
                catch (Exception ex)
                {
                }
            }
            
            #endregion

            #region
            
            var tbl9 = oldDBContext.ViewForms.ToList();

            foreach (var o in tbl9)
            {
                try
                {
                    EESContext newDBContext = new EESContext();
                    var of = new Form
                    {
                        DocumentCode=o.DocId,
                        DocumentName=o.DocName,
                        DocumentType=o.DocTypeName,
                        FormCode=o.FormId,
                        FormName=o.FormName,
                        OfficeName=o.ManName,
                        Level3ProcessCode=o.ThreeLevelId,
                        Level3ProcessName=o.ThreeLevelName,
                        Level4ProcessCode=o.FourLevelNo,
                        Level4ProcessName=o.FourLevelName,
                        File=o.ZipAddress
                    };
                    newDBContext.Forms.Add(of);
                    newDBContext.Database.OpenConnection();
                    try
                    {
                        newDBContext.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        newDBContext.Database.CloseConnection();
                    }
                }
                catch (Exception ex)
                {
                }
            }
            #endregion

            #region
            
            var tbl10 = oldDBContext.TblOffers.ToList();
            foreach (var o in tbl10)
            {
                try
                {
                    EESContext newDBContext = new EESContext();
                    var of = new Participant
                    {
                        ID=o.Idof,
                        Percent=0,
                        ProposalID=(int)o.Idpr,
                        UserID=Convert.ToInt32(o.Emno)
                    };
                    newDBContext.Participants.Add(of);
                    newDBContext.Database.OpenConnection();
                    try
                    {
                        newDBContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Participants ON");
                        newDBContext.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        newDBContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Participants OFF");
                        newDBContext.Database.CloseConnection();
                    }
                }
                catch (Exception ex)
                {
                }
            }

            #endregion


            #region 
            EESContext newDBContextt = new EESContext();
            UserRole userRole = new UserRole()
            {
                UserID = 534690,
                RoleID = 1
            };
            newDBContextt.Add(userRole);
            newDBContextt.SaveChanges();
            #endregion
            Console.WriteLine("Hello World!");
        }
    }
}
