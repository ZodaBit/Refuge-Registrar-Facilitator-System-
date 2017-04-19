using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ARRAre
{
    class RefugeeDB
    {

        public static String ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\ArraDB\ARRA.accdb";
        
          OleDbConnection Arracon=new OleDbConnection(ConnectionString);
// retrive information from the user table 
          public DataSet LogUser(string username, string password)
          {
              //Gets a user from fhe data base:= if avalabel it retuns info about the user if not it returns null

              string sqlGetUser = "SELECT * FROM User_tbl WHERE UserID=@user_name AND Password=@user_pass";

               OleDbCommand  cmd = new OleDbCommand(sqlGetUser,Arracon);
             OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
              DataSet ds = new DataSet();

              cmd.Parameters.AddWithValue("@user_name", username);
              cmd.Parameters.AddWithValue("@user_pass", password);
              // cmd.Parameters.AddWithValue("@role", role);

              try
              {
                  Arracon.Open();
                  adp.Fill(ds, "LogUser");
              }

              finally
              {
                  Arracon.Close();
              }

              return ds;

          }

//create user  account 
    public bool insertuser (string username, string password)
          {
              int inserted = 0;
              string sqlinsert = "INSERT INTO User_tbl (UserID,Password) VALUES(@user,@pass)";
              OleDbCommand cmd = new OleDbCommand(sqlinsert, Arracon);
              cmd.Parameters.AddWithValue("@user", username);
              cmd.Parameters.AddWithValue("@pass", password);
           try
           {
               Arracon.Open();
               inserted = cmd.ExecuteNonQuery();
           }
        catch(Exception err)
           {

           }
        finally
           {
               Arracon.Close();
           }
           if (inserted > 0)
               return true;
           else
               return false;
          }
    // upadate user accoutn

   // return all user account from the database
    public DataSet GetAllReffugeebbb()
    {
        string sqlalluser = "SELECT * FROM User_tbl";
        OleDbCommand cmd = new OleDbCommand(sqlalluser, Arracon);
        OleDbDataAdapter adp = new OleDbDataAdapter(cmd);


        DataSet ds = new DataSet();


        try
        {
            Arracon.Open();
            adp.Fill(ds, "AllUser");
        }
        /*  catch (Exception err)
          {

          }*/
        finally
        {
            Arracon.Close();
        }

        return ds; // retun search result
    }
           

        //method insert refuge records to the database
          public bool InsertRefugees(string rf_fileno, string rf_rc, string campname, string fname, string familytype, string mname, string lname, string mothername, string sex, int age, string dofb, string placeob, string religion, string tribe, string Marital, int familsysize, string formerOcc, string Skill, string nationality, string city, string subcity, string zone, string wereda, string kebele, string houseno, string phonenum, string trofu, string remark, string regName, string regdate, byte[] photho)
        {

            //  // 
            int inserted = 0;
            string sqlInserte = "INSERT INTO Refugee_tbl (rfFileNO,rfRCNO,rfCampName,rfFirstName,  rfFamilyType,rfMiddleName,rfLastName,rfMotherName,rfSex,rfAge,rfDOB,rfPlaceOB,rfReligion,rfTribe,rfMaritalStatus,rfFamilySize,rfFormerOccupation,rfSkill,rfNationality,rfCity,rfSubCity,rfZone,rfWereda,rfKebele,rfHouseNO,rfTRU,rfPhoneNum,rfRemark,rfregbuy,rfregDate,rfImage) VALUES (@rfFileNO,@rfRCNO,@rfCampName,@rfFirstName,@rfFamilyType,@rfMiddleName,@rfLastName,@rfMotherName,@rfSex,@rfAge,@rfDOB,@rfPlaceOB,@rfReligion,@rfTribe,@rfMaritalStatus,@rfFamilySize,@rfFormerOccupation,@rfSkill,@rfNationality,@rfCity,@rfSubCity,@rfZone,@rfWereda,@rfKebele,@rfHouseNO,@rfTRU,@rfPhoneNum,@rfRemark,@rfregbuy,@rfregDate,@rfImage)";
            OleDbCommand cmd=new OleDbCommand(sqlInserte,Arracon);
           
              cmd.Parameters.AddWithValue(" @rfFileNO",rf_fileno);
            cmd.Parameters.AddWithValue("@rfRCNO",rf_rc);
               cmd.Parameters.AddWithValue(" @rfCampName",campname);
                 cmd.Parameters.AddWithValue( "@rfFirstName",fname);
                 cmd.Parameters.AddWithValue("@rfFamilyType", familytype);
                  cmd.Parameters.AddWithValue("@rfMiddleName",mname);
                  cmd.Parameters.AddWithValue("@rfLastName",lname);
                  cmd.Parameters.AddWithValue("@rfMotherName",mothername);
                  cmd.Parameters.AddWithValue("@rfSex",sex);
                  cmd.Parameters.AddWithValue("@rfAge",age);
                  cmd.Parameters.AddWithValue("@rfDOB",dofb);
                  cmd.Parameters.AddWithValue("@rfPlaceOB",placeob);
                  cmd.Parameters.AddWithValue("@rfReligion",religion);
                  cmd.Parameters.AddWithValue("@rfTribe",tribe);
                  cmd.Parameters.AddWithValue("@rfMaritalStatus",Marital);
                 cmd.Parameters.AddWithValue(" @rfFamilySize",familsysize);
                 cmd.Parameters.AddWithValue(" @rfFormerOccupation",formerOcc);
                  cmd.Parameters.AddWithValue("@rfSkill",Skill);
                  cmd.Parameters.AddWithValue("@rfNationality",nationality);
                  cmd.Parameters.AddWithValue("@rfCity",city);
                  cmd.Parameters.AddWithValue("@rfSubCity",subcity);
                  cmd.Parameters.AddWithValue("@rfZone",zone);
                 cmd.Parameters.AddWithValue(" @rfWereda",wereda);
                  cmd.Parameters.AddWithValue("@rfKebele",kebele);
                  cmd.Parameters.AddWithValue("@rfHouseNO",houseno);
                  cmd.Parameters.AddWithValue("@rfTRU",trofu);
                 cmd.Parameters.AddWithValue(" @rfPhoneNum",phonenum);
                 cmd.Parameters.AddWithValue("@rfRemark", remark);
                  cmd.Parameters.AddWithValue("@rfregbuy",regName);
                  cmd.Parameters.AddWithValue("@rfregDate",regdate);
                  OleDbParameter imgparameter = cmd.Parameters.AddWithValue("@rfImage", SqlDbType.Binary);
                  imgparameter.Value = photho;
                  imgparameter.Size = photho.Length;


        
            try
            {
                Arracon.Open();
                inserted = cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {

            }
            finally
            {
                Arracon.Close();
            }

            if (inserted > 0)     //inserte is SuccesFull
                return true;
            else                 //inserte Failled
                return false;

   
        }
//update reffugee data 
          public bool UpdateRefugee(string rfid,string rf_fileno, string rf_rc, string campname, string fname, string familytype, string mname, string lname, string mothername, string sex, int age, string dofb, string placeob, string religion, string tribe, string Marital, int familsysize, string formerOcc, string Skill, string nationality, string city, string subcity, string zone, string wereda, string kebele, string houseno, string phonenum, string trofu, string remark, string regName, string regdate, byte[] photho)
          {
              int Updated = 0;
              string sqlupdaterefugee = "UPDATE Refugee_tbl  SET rfFileNO=@rfFileNO ,rfRCNO=@rfRCNO,rfCampName=@rfCampName,rfFirstName=@rfFirstName,rfFamilyType=@rfFamilyType,rfMiddleName=@rfMiddleName,rfLastName=@rfLastName,rfMotherName=@rfMotherName,rfSex=@rfSex,rfAge=@rfAge,rfDOB=@rfDOB,rfPlaceOB=@rfPlaceOB,rfReligion=@rfReligion,rfTribe=@rfTribe,rfMaritalStatus=@rfMaritalStatus,rfFamilySize=@rfFamilySize,rfFormerOccupation=@rfFormerOccupation,rfSkill=@rfSkill,rfNationality=@rfNationality,rfCity=@rfCity,rfSubCity=@rfSubCity,rfZone=@rfZone,rfWereda=@rfWereda,rfKebele=@rfKebele,rfHouseNO=@rfHouseNO,rfTRU=@rfTRU,rfPhoneNum=@rfPhoneNum,rfRemark=@rfRemark,rfregbuy=@rfregbuy,rfregDate=@rfregDate ,rfImage=@@rfImage WHERE rfIDNO=@rfIDNO";
          
              OleDbCommand cmd = new OleDbCommand(sqlupdaterefugee, Arracon);

              cmd.Parameters.AddWithValue(" @rfFileNO", rf_fileno);
              cmd.Parameters.AddWithValue("@rfRCNO", rf_rc);
              cmd.Parameters.AddWithValue(" @rfCampName", campname);
              cmd.Parameters.AddWithValue("@rfFirstName", fname);
              cmd.Parameters.AddWithValue("@rfFamilyType", familytype);
              cmd.Parameters.AddWithValue("@rfMiddleName", mname);
              cmd.Parameters.AddWithValue("@rfLastName", lname);
              cmd.Parameters.AddWithValue("@rfMotherName", mothername);
              cmd.Parameters.AddWithValue("@rfSex", sex);
              cmd.Parameters.AddWithValue("@rfAge", age);
              cmd.Parameters.AddWithValue("@rfDOB", dofb);
              cmd.Parameters.AddWithValue("@rfPlaceOB", placeob);
              cmd.Parameters.AddWithValue("@rfReligion", religion);
              cmd.Parameters.AddWithValue("@rfTribe", tribe);
              cmd.Parameters.AddWithValue("@rfMaritalStatus", Marital);
              cmd.Parameters.AddWithValue(" @rfFamilySize", familsysize);
              cmd.Parameters.AddWithValue(" @rfFormerOccupation", formerOcc);
              cmd.Parameters.AddWithValue("@rfSkill", Skill);
              cmd.Parameters.AddWithValue("@rfNationality", nationality);
              cmd.Parameters.AddWithValue("@rfCity", city);
              cmd.Parameters.AddWithValue("@rfSubCity", subcity);
              cmd.Parameters.AddWithValue("@rfZone", zone);
              cmd.Parameters.AddWithValue(" @rfWereda", wereda);
              cmd.Parameters.AddWithValue("@rfKebele", kebele);
              cmd.Parameters.AddWithValue("@rfHouseNO", houseno);
              cmd.Parameters.AddWithValue("@rfTRU", trofu);
              cmd.Parameters.AddWithValue(" @rfPhoneNum", phonenum);
              cmd.Parameters.AddWithValue("@rfRemark", remark);
              cmd.Parameters.AddWithValue("@rfregbuy", regName);
              cmd.Parameters.AddWithValue("@rfregDate", regdate);
              OleDbParameter imgparameter = cmd.Parameters.AddWithValue("@rfImage", SqlDbType.Binary);
              imgparameter.Value = photho;
              imgparameter.Size = photho.Length;
              cmd.Parameters.AddWithValue("@rfIDNO", rfid);
              try
              {
                  Arracon.Open();
                  Updated = cmd.ExecuteNonQuery();
              }
              catch (Exception err)
              {

              }
              finally
              {
                  Arracon.Close();
              }

              if (Updated > 0)     //Update is SuccesFull
                  return true;
              else                 //Update Failled
                  return false;

          }
          public DataSet GetAllReffugee()
          {
              string sqlAllrefugee = "SELECT * FROM Refugee_tbl";
              OleDbCommand cmd = new OleDbCommand(sqlAllrefugee, Arracon);
              OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
              

              DataSet ds = new DataSet();


              try
              {
                  Arracon.Open();
                  adp.Fill(ds, "AllReffugee");
              }
              /*  catch (Exception err)
                {

                }*/
              finally
              {
                  Arracon.Close();
              }

              return ds; // retun search result
           }
   //get reffugies by id

          public DataSet GetReffugeebyId(string RefId)
          {
              string sqlSelectRefugee = "SELECT * FROM Refugee_tbl WHERE rfIDNO=@refid";
              OleDbCommand cmd = new OleDbCommand(sqlSelectRefugee, Arracon);
              OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
             
              DataSet ds = new DataSet();

              cmd.Parameters.AddWithValue("@refid", RefId);

              try
              {
                  Arracon.Open();
                  adp.Fill(ds, "AllReffugee");
              }
              catch (Exception err)
              {

              }
              finally
              {
                  Arracon.Close();
              }

              return ds; // retun search result
          }
    //get refugi by racion card number
          public DataSet GetReffugeebyRacionCArd(string Refcardnum)
          {
              string sqlSelectRefugee = "SELECT * FROM Refugee_tbl WHERE rfRCNO=@rfrationcared";
              OleDbCommand cmd = new OleDbCommand(sqlSelectRefugee, Arracon);
              OleDbDataAdapter adp = new OleDbDataAdapter(cmd);

              DataSet ds = new DataSet();

              cmd.Parameters.AddWithValue("@rfrationcared", Refcardnum);

              try
              {
                  Arracon.Open();
                  adp.Fill(ds, "AllReffugee");
              }
              catch (Exception err)
              {

              }
              finally
              {
                  Arracon.Close();
              }

              return ds; // retun search result
          }
    }
}
