using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EBV.DAL.DbTierTableAdapters;
using System.Data;
namespace EBV.BLL
{
    public class BLL
    {
        ADMINTableAdapter objAdmin;
        COMPANYTableAdapter objcmp;
        EMPLOYEETableAdapter objemp;
        REGISTERTableAdapter objreg;
        BITTableAdapter objbit;
        VERIFYTableAdapter objver;
        THIRDPARTYTableAdapter objthr;
        CATEGORYTableAdapter objcat;
        EXPERIENCETableAdapter objexp;
        GUESTTableAdapter objguest;
        public DataTable getAdmin()
        {
            objAdmin = new ADMINTableAdapter();
            return objAdmin.GetAdmin();
        }
        public DataTable getCompany()
        {
            objcmp = new COMPANYTableAdapter();
            return objcmp.GetCompany();
        }

        public bool Adminlogin(string username, string password)
        {
            objAdmin = new ADMINTableAdapter();
            return Convert.ToBoolean(objAdmin.AdminLogin(username, password));
        }
        public bool Insertcompany(string cname, string mail, string pass)
        {
            objcmp = new COMPANYTableAdapter();
            return Convert.ToBoolean(objcmp.InsertCompany(cname, mail, pass));
        }
        public bool updateCompany(string cname, string mail, string pass, int cId)
        {
            objcmp = new COMPANYTableAdapter();
            return objcmp.UpdateCompany(cname, mail, pass, cId) > 0;
        }
        public bool deleteCompany(int cId)
        {
            objcmp = new COMPANYTableAdapter();
            return objcmp.DeleteCompany(cId) > 0;
        }
        public bool companyLogin(string mail, string pass)
        {
            objcmp = new COMPANYTableAdapter();
            return objcmp.CompanyLogin(mail, pass) > 0;
        }
        public bool employeeLogin(string mail, string pass)
        {
            objemp = new EMPLOYEETableAdapter();
            return Convert.ToBoolean(objemp.EmployeeLogin(mail, pass));
        }
        public DataTable getRegister()
        {
            objreg = new REGISTERTableAdapter();
            return objreg.GetRegister();
        }
        public bool insertRegister(string cname, string mail, string phone)
        {
            objreg = new REGISTERTableAdapter();
            return objreg.InsertRegister(cname, mail, phone) > 0;
        }
        public bool checkRegister(string cname)
        {
            objreg = new REGISTERTableAdapter();
            return objreg.CheckRegister(cname) > 0;
        }
        public bool deleteRegister(string cname)
        {
            objreg = new REGISTERTableAdapter();
            return objreg.DeleteRegister(cname) > 0;
        }
        public DataTable getCompanyDetails(string cname)
        {
            objcmp = new COMPANYTableAdapter();
            return objcmp.GetCompanyDetails(cname);
        }
        public bool updateCompanyDetails(int id, int no, string add, string web)
        {
            objcmp = new COMPANYTableAdapter();
            return objcmp.UpdateCompanyDetails(no, add, web, id) > 0;
        }
        public DataTable getEmployee()
        {
            objemp = new EMPLOYEETableAdapter();
            return objemp.GetEmployee();
        }
        public bool InsertEmployee(string ename, string mail, string pass,int cid,int EmployeeId)
        {
            objemp = new EMPLOYEETableAdapter();
            return objemp.InsertEmployee(ename, mail, pass, cid,EmployeeId) > 0;
        }
        public bool updateEmployee(string ename, string mail, string pass,int id)
        {
            objemp = new EMPLOYEETableAdapter();
            return objemp.UpdateEmployee(ename, mail,pass,id) > 0;
        }
        public bool deleteEmployee(int cId)
        {
            objemp = new EMPLOYEETableAdapter();
            return objemp.DeleteEmployee(cId) > 0;
        }
        public bool setBit(int cname, string bit)
        {
            objbit = new BITTableAdapter();
            return Convert.ToBoolean(objbit.SetBit(cname, bit));
        }
        public DataTable getCname(string cname)
        {
            objcmp = new COMPANYTableAdapter();
            return objcmp.GetCname(cname);
        }
        public DataTable getId(string bit)
        {
            objbit = new BITTableAdapter();
            return objbit.GetId(bit);
        }
        public DataTable getVerify(int eid)
        {
            objver = new VERIFYTableAdapter();
            return objver.GetVerify(eid);
        }
        public DataTable getThird(string bit)
        {
            objthr = new THIRDPARTYTableAdapter();
            return objthr.GetThird(bit);
        }
        public bool checkEid(int eid)
        {
            objbit = new BITTableAdapter();
            return objbit.CheckEid(eid) > 0;
        }
        public bool checkSet(string bit, int cname)
        {
            objbit = new BITTableAdapter();
            return objbit.CheckSet(bit, cname) > 0;
        }
        public bool deleteBit(int cname)
        {
            objbit = new BITTableAdapter();
            return objbit.DeleteBit(cname) > 0;
        }
        public DataTable getCatById(int cid)
        {
            objcat = new CATEGORYTableAdapter();
            return objcat.GetCatById(cid);
        }
        public bool insertCategory(string cat, int id)
        {
            objcat = new CATEGORYTableAdapter();
            return objcat.InsertCategory(cat, id) > 0;
        }
        public bool updateCategory(string cat, int id)
        {
            objcat = new CATEGORYTableAdapter();
            return objcat.UpdateCategory(cat, id) > 0;
        }
        public bool deleteCategory(int id)
        {
            objcat = new CATEGORYTableAdapter();
            return objcat.DeleteCategory(id) > 0;
        }
        public DataTable getEmployeeById(int id)
        {
            objemp = new EMPLOYEETableAdapter();
            return objemp.GetEmployeeById(id);
        }
        public bool DeleteExperience(int id)
        {
            objexp = new EXPERIENCETableAdapter();
            return objexp.Deleteemployeeexp(id) > 0;
        }
        public bool UpdateExperience(string Domain, string Projects, int NoOfYrs, string Description, string CurrentProject, int cid)
        {
            objexp = new EXPERIENCETableAdapter();
            return objexp.Updateemployeeexp(Domain, Projects, NoOfYrs, Description, CurrentProject, cid) > 0;
        }
        public bool InsertExperience(string Domain, string Projects, int NoOfYrs, string Description, string CurrentProject, int cid)
        {
            objexp = new EXPERIENCETableAdapter();
            return objexp.Insertemployeeexp(Domain, Projects, NoOfYrs, Description, CurrentProject, cid) > 0;
        }
        public DataTable getGuest()
        {
            objguest = new GUESTTableAdapter();
            return objguest.GetGuest();
        }
        public bool checkGuest(string mail)
        {
            objguest = new GUESTTableAdapter();
            return objguest.CheckGuest(mail) > 0;
        }
        public bool updateGuest(string mail, string pass, int bit, int gid)
        {
            objguest = new GUESTTableAdapter();
            return objguest.UpdateGuest(mail, pass, bit, gid) > 0;
        }
        public bool deleteGuest(int id)
        {
            objguest = new GUESTTableAdapter();
            return objguest.DeleteGuest(id) > 0;
        }
        public DataTable getguestdata()
        {
            objguest = new GUESTTableAdapter();
            return objguest.GetGuestData();
        }
        public bool insertGuestData(string name, string mail, string contact)
        {
            objguest = new GUESTTableAdapter();
            return objguest.InsertGuestData(name, mail, contact) > 0;
        }
        public DataTable getGuestByBit(int bit)
        {
            objguest = new GUESTTableAdapter();
            return objguest.GetGuestByBit(bit);
        }
        public bool guestLogin(string mail, string pass)
        {
            objguest = new GUESTTableAdapter();
            return objguest.GuestLogin(mail, pass) > 0;
        }
        public DataTable getGuestByMail(string mail)
        {
            objguest = new GUESTTableAdapter();
            return objguest.GetGuestByMail(mail);
        }
        public bool insertThird(int id, string bit)
        {
            objthr = new THIRDPARTYTableAdapter();
            return objthr.InsertThird(id, bit) > 0;
        }
        public DataTable getCategory()
        {
            objcat = new CATEGORYTableAdapter();
            return objcat.GetCategory();
        }
        public bool updatecategoryvacancy(int vacancy, int catId)
        {
            objcat = new CATEGORYTableAdapter();
            return objcat.UpdateCategoryVacancy(vacancy, catId) > 0;
        }
        public DataTable getExperienceByCid(int cid)
        {
            objexp = new EXPERIENCETableAdapter();
            return objexp.GetExperienceByCid(cid);
        }
        public DataTable experienceVerify(int id)
        {
            objexp = new EXPERIENCETableAdapter();
            return objexp.ExperienceVerify(id);
        }
        public bool updateEmployeeDetails(string ename, string mail, string pass, string address, string adhaar, int id)
        {
            objemp = new EMPLOYEETableAdapter();
            return objemp.UpdateEmployeeDetails(ename, mail, pass, address, adhaar, id) > 0;
        }

        public bool deleteEmployeeDetails(int id)
        {
            objemp = new EMPLOYEETableAdapter();
            return objemp.DeleteEmployeeDetails(id) > 0;
        }
        public DataTable get16bit()
        {
            objthr = new THIRDPARTYTableAdapter();
            return objthr.Get16bit();
        }
        public bool updateThirdParty(string a, string b, string c, string d, int e)
        {
            objthr = new THIRDPARTYTableAdapter();
            return objthr.UpdateThirdParty(a, b, c, e, d) > 0;
        }
        public DataTable catNested(string cname)
        {
            objcat = new CATEGORYTableAdapter();
            return objcat.CatNested(cname);
        }
        public bool update16bit(string bit, int id)
        {
            objthr = new THIRDPARTYTableAdapter();
            return objthr.Update16bit(bit, id) > 0;
        }
        public bool checkThirdParty(int id)
        {
            objthr = new THIRDPARTYTableAdapter();
            return objthr.CheckThirdParty(id) > 0;
        }
        public bool checkEmployee16bit(string bit)
        {
            objbit = new BITTableAdapter();
            return objbit.CheckEmployee16bit(bit) > 0;
        }
        public DataTable getName(int eid)
        {
            objemp = new EMPLOYEETableAdapter();
            return objemp.GetName(eid);
        }
        public DataTable getGuestName(int gid)
        {
            objguest = new GUESTTableAdapter();
            return objguest.GetGuestName(gid);
        }
        public bool checkEmpById(int id)
        {
            objemp = new EMPLOYEETableAdapter();
            return Convert.ToBoolean(objemp.CheckEmpById(id));
        }
        public bool updateNewEmployee(int cid, string mail, string pass, int id)
        {
            objemp = new EMPLOYEETableAdapter();
            return objemp.UpdateNewEmployee(cid, mail, pass, id)>0;
        }
        public bool insertEmpVerify(int id, string a, string b, string c, string d)
        {
            objver = new VERIFYTableAdapter();
            return objver.InsertEmpVerify(id, a, b, c, d)>0;
        }
        public DataTable getEmpIdByName(string name)
        {
            objemp = new EMPLOYEETableAdapter();
            return objemp.GetEmpIdByName(name);
        }
        public bool deleteGuestByName(string name)
        {
            objguest = new GUESTTableAdapter();
            return objguest.DeleteGuestByName(name) > 0;
        }
        public int GetLastEmpId()
        {
            objemp = new EMPLOYEETableAdapter();
            return Convert.ToInt32(objemp.GetLastEmployee()[0][0]);
        }
        public DataTable getEid(string mail)
        {
            objemp = new EMPLOYEETableAdapter();
            return objemp.GetEid(mail);
        }
        public DataTable getEidByName(string name)
        {
            objemp = new EMPLOYEETableAdapter();
                return objemp.GetEidByName(name);
                          
        }
        public DataTable getEmpByCid(int cid)
        {
            objemp = new EMPLOYEETableAdapter();
                return objemp.GetEmpByCid(cid);
            
        }
        public DataTable getCmpEmpCount()
        {
            objcmp = new COMPANYTableAdapter();
            return objcmp.GetCmpEmpCount();
        }
        
    }
}