using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaceRecognition.Model;
namespace FaceRecognition.Classes
{
    class Services
    {
        public bool AddNewStudents(T_OGR t_OGR,T_KEY t_KEY) {

            try
            {
                using (DBOBISEntities entities = new DBOBISEntities())
                {
                    var check = entities.T_OGR.Where(x => x.OGR_TC == t_OGR.OGR_TC).FirstOrDefault();
                    if (check != null)
                    {
                        return false;
                    }
                    else
                    {
                        entities.T_OGR.Add(t_OGR);
                        entities.T_KEY.Add(t_KEY);
                        entities.SaveChanges();
                        return true;

                    }

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public bool UpdateStudents(T_OGR t_OGR) {

            try
            {
                using (DBOBISEntities entities = new DBOBISEntities())
                {
                    var update = entities.T_OGR.Where(x => x.OGR_TC == t_OGR.OGR_TC).FirstOrDefault();

                    if (update == null)
                    {
                        return false;
                    }
                    else
                    {
                        update.OGR_BOLUM = t_OGR.OGR_BOLUM;
                        update.OGR_CINSIYET = t_OGR.OGR_CINSIYET;
                        update.OGR_DOGUMT = t_OGR.OGR_DOGUMT;
                        update.OGR_FAKULTE = t_OGR.OGR_FAKULTE;
                        update.OGR_ISIM = t_OGR.OGR_ISIM;
                        update.OGR_OKULNU = t_OGR.OGR_OKULNU;
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

        public bool delStudents(long ogr_TC) {

            try
            {
                using (DBOBISEntities entities = new DBOBISEntities())
                {
                    var delstudentkeytable = entities.T_KEY.Where(x => x.OGR_OKULNU == ogr_TC).FirstOrDefault();
                    var delstudenttable = entities.T_OGR.Where(x => x.OGR_TC == ogr_TC).FirstOrDefault();
                    if (delstudenttable == null)
                    {
                        return false;

                    }
                    else
                    {
                        if (delstudentkeytable != null)
                        {
                            entities.T_KEY.Remove(delstudentkeytable);
                            entities.T_OGR.Remove(delstudenttable);
                            entities.SaveChanges();
                            return true;
                        }
                        else
                        {
                            entities.T_OGR.Remove(delstudenttable);
                            entities.SaveChanges();
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public bool AddnewClass(T_DERS t_DERS) {

            try
            {
                using (DBOBISEntities entities = new DBOBISEntities())
                {
                    var check = entities.T_DERS.Where(x => x.DERS_KODU == t_DERS.DERS_KODU).FirstOrDefault();
                    if (check != null)
                    {
                        return false;
                    }
                    else
                    {
                        entities.T_DERS.Add(t_DERS);
                        entities.SaveChanges();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        public bool UpdateClass(T_DERS t_DERS) {

            try
            {
                using (DBOBISEntities entities = new DBOBISEntities())
                {
                    var updateClass = entities.T_DERS.Where(x => x.DERS_KODU == t_DERS.DERS_KODU).FirstOrDefault();
                    if (updateClass == null)
                    {
                        return false;
                    }
                    else
                    {
                        updateClass.DERS_AKADEMİSYENI = t_DERS.DERS_AKADEMİSYENI;
                        updateClass.DERS_BLOCK = t_DERS.DERS_BLOCK;
                        updateClass.DERS_ISMI = t_DERS.DERS_ISMI;
                        updateClass.DERS_KODU = t_DERS.DERS_KODU;
                        updateClass.DERS_SINIF_KOD = t_DERS.DERS_SINIF_KOD;
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public bool delClass(string classNu) {

            try
            {
                using (DBOBISEntities entities = new DBOBISEntities())
                {
                    var delClass = entities.T_DERS.Where(x => x.DERS_KODU == classNu).FirstOrDefault();
                    var checkStudent = entities.T_KEY.Where(x => x.DERS_KODU == classNu).FirstOrDefault();
                    if (delClass == null)
                    {
                        return false;
                    }
                    else
                    {
                        if (checkStudent != null)
                        {
                            return false;
                        }
                        else
                        {
                            entities.T_DERS.Remove(delClass);
                            entities.SaveChanges();
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public List<string> GetDersKod() {

            try
            {
                using (DBOBISEntities entities = new DBOBISEntities())
                {
                    return entities.T_DERS.Select(x => x.DERS_KODU).ToList();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

        public List<Tuple<string, long>> GetOgrList(string ClassNU){

            try
            {
                using (DBOBISEntities entities = new DBOBISEntities())
                {
                    var TCnu = entities.T_KEY.Where(x=> x.DERS_KODU==ClassNU).Select(x=> x.OGR_OKULNU);
                    List<Tuple<string, long>> listStudent = new List<Tuple<string, long>>();
                    foreach (var item in TCnu)
                    {
                        var ogrIsim = entities.T_OGR.Where(x => x.OGR_TC == item).Select(x=>x.OGR_ISIM).FirstOrDefault();
                        var ogrOkul= entities.T_OGR.Where(x => x.OGR_TC == item).Select(x => x.OGR_OKULNU).FirstOrDefault();
                        listStudent.Add(new Tuple<string,long>(ogrIsim,ogrOkul));

                    }
                    return listStudent.ToList();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        public List<string> GetStudentsName(string classNu) {

            try
            {
                using (DBOBISEntities entities= new DBOBISEntities())
                {
                    var tcNU = entities.T_KEY.Where(x=> x.DERS_KODU==classNu).Select(x=> x.OGR_OKULNU);
                    List<string> ogrisimlist = new List<string>();
                    foreach (var item in tcNU)
                    {
                        var ogrisim = entities.T_OGR.Where(x=> x.OGR_TC==item).Select(x=> x.OGR_ISIM).FirstOrDefault();
                        ogrisimlist.Add(ogrisim.Trim());
                    }
                    return ogrisimlist.ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }



            


    }
}
