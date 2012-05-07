using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Apriori
{
    class dbConnect
    {
        public String strConn = "";
        public String _strConn
        {
            get { return strConn; }
            set { strConn = value; }
        }
        public SqlConnection conn = new SqlConnection();
        //public SqlConnection conn = new SqlConnection("Server = NGUYENVANLAM-PC; Database = SDD_1; Integrated Security = true");
        public void Connect()
        {
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.ConnectionString = strConn;
                    conn.Open();
                }
                catch
                {
                    MessageBox.Show("Không thể kết nối cơ sở dữ liệu. Vui lòng kiểm tra lại thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public DataTable exeSelect(String strCommand, String strTableName)
        {
            Connect();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strCommand, conn.ConnectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, strTableName);
            dt = ds.Tables[0];
            return dt;
        }
        public void exeQuery(String strCommand)
        {
            Connect();
            SqlCommand sqlC = new SqlCommand(strCommand, conn);
            sqlC.ExecuteNonQuery();
        }
        public ListBox getDbName()
        {
            Connect();
            SqlCommand sqlC = new SqlCommand();
            sqlC.Connection = conn;
            sqlC.CommandType = CommandType.StoredProcedure;
            sqlC.CommandText = "sp_databases";
            SqlDataReader sqlD = sqlC.ExecuteReader(); 
            ListBox lstDbName = new ListBox();
            try {
                
                while (sqlD.Read())
                {
                    //if (sqlD.GetString(0) != "master" & sqlD.GetString(0) != "tempdb" & sqlD.GetString(0) != "model" & sqlD.GetString(0) != "msdb")
                   // {
                        lstDbName.Items.Add(sqlD.GetString(0));
                   // }
                }
            }
            catch { }
            sqlD.Close();
            return lstDbName;
        }
        // Hàm hiển thị tên các các Field trong một table
        public ListBox getColName(String tableName)
        {
            Connect();
            SqlCommand sqlC = new SqlCommand();
            sqlC.Connection = conn;
            sqlC.CommandType = CommandType.Text;
            sqlC.CommandText = "select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where table_name='"+tableName+"'";
            SqlDataReader sqlDR = sqlC.ExecuteReader();
            ListBox lstColName = new ListBox();
            while (sqlDR.Read())
            {
                lstColName.Items.Add(sqlDR.GetString(0));
            }
            sqlDR.Close();
            return lstColName;
        }
        //Hàm hiển thị tên của các Field là khóa chính trong một table
        public ListBox getPrimaryKeyColName(String tableName)
        {
            Connect();
            SqlCommand sqlC = new SqlCommand();
            sqlC.Connection = conn;
            sqlC.CommandType = CommandType.Text;
            sqlC.CommandText = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc JOIN INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE ccu ON tc.CONSTRAINT_NAME = ccu.Constraint_name WHERE tc.CONSTRAINT_TYPE = 'Primary Key' and tc.TABLE_NAME='" + tableName.Trim() +"'";
            SqlDataReader sqlDR = sqlC.ExecuteReader();
            ListBox lstColName = new ListBox();
            while (sqlDR.Read())
            {
                lstColName.Items.Add(sqlDR.GetString(0));
            }
            sqlDR.Close();
            return lstColName;
        }
        //Hàm hiển thị tên của các Field là khóa ngoại trong một table
        public ListBox getForeignKeyColName(String tableName)
        {
            Connect();
            SqlCommand sqlC = new SqlCommand();
            sqlC.Connection = conn;
            sqlC.CommandType = CommandType.Text;
            sqlC.CommandText = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc JOIN INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE ccu ON tc.CONSTRAINT_NAME = ccu.Constraint_name WHERE tc.CONSTRAINT_TYPE = 'Foreign Key' and tc.TABLE_NAME='" + tableName.Trim() + "'";
            SqlDataReader sqlDR = sqlC.ExecuteReader();
            ListBox lstColName = new ListBox();
            while (sqlDR.Read())
            {
                lstColName.Items.Add(sqlDR.GetString(0));
            }
            sqlDR.Close();
            return lstColName;
        }
        public int demLanXuatHien(PTPB UngVien, ListBox lstT)
        {
            String[] strName = UngVien.maPT.Split(',');
            int demUV = 0;//Số lần xuất hiện của ứng viên
            for (int i = 0; i < lstT.Items.Count; i++)
            {
                long maHD = Convert.ToInt64(lstT.Items[i].ToString());
                String strQ="select masp from cthd where mahd=" + maHD + "";
                DataTable dtHD = exeSelect(strQ, "cthd");
                int demTheoBo = 0;//Kiểm tra xem ứng viên có xuất hiện trong 1 bộ hay ko.
                for (int j = 0; j < dtHD.Rows.Count; j++)
                {
                    DataRow dtR = dtHD.Rows[j];
                    String maSP = dtR["masp"].ToString();
                    foreach(String k in strName)
                    {
                        if (String.Compare(maSP, k) == 0) 
                        {
                            demTheoBo++;
                            break;
                        } 
                    }
                }
                if (demTheoBo == strName.Count()) demUV++;
            }
            return demUV;
        }
        public int demLanXuatHien(String UngVien, ListBox lstT)
        {
            String[] strName = UngVien.Split(',');
            int demUV = 0;//Số lần xuất hiện của ứng viên
            for (int i = 0; i < lstT.Items.Count; i++)
            {
                long maHD = Convert.ToInt64(lstT.Items[i].ToString());
                String strQ = "select masp from cthd where mahd=" + maHD + "";
                DataTable dtHD = exeSelect(strQ, "cthd");
                int demTheoBo = 0;//Kiểm tra xem ứng viên có xuất hiện trong 1 bộ hay ko.
                for (int j = 0; j < dtHD.Rows.Count; j++)
                {
                    DataRow dtR = dtHD.Rows[j];
                    String maSP = dtR["masp"].ToString();
                    foreach (String k in strName)
                    {
                        if (k != "")
                        {
                            if (String.Compare(maSP, k) == 0)
                            {
                                demTheoBo++;
                                break;
                            }
                        }
                    }
                }
                if (demTheoBo == strName.Count()-1) demUV++;
            }
            return demUV;
        }
        public void timTapUngVien(ListBox lstTapPhoBien, ListBox lstTapUngVien, int soPhanTu)
        {
            ListBox lstTemp = new ListBox();
            //Lấy ra các tập phổ biến có số phân từ = số vòng lặp - 1
            for (int i = 0; i < lstTapPhoBien.Items.Count; i++)
            {
                String k=lstTapPhoBien.Items[i].ToString();
                String[] s = k.Split(',');
                ListBox Temp = new ListBox();
                foreach (String j in s)
                {
                    if (j != "")
                        Temp.Items.Add(j);
                }
                if (Temp.Items.Count == (soPhanTu - 1))
                {
                    lstTemp.Items.Add(k);
                }
            }
            ListBox lstTapUngVienTemp = new ListBox();
            timTapCon(lstTemp, lstTapUngVien);
            //Lấy các ứng viên có số phần từ trùng với số lần lặp
            for (int i = 0; i < lstTapUngVien.Items.Count; i++)
            {
                String k = lstTapUngVien.Items[i].ToString();
                String[] s = k.Split(',');
                int dem = 0;
                foreach (String j in s)
                {
                    if (j != "") dem++;
                }
                if (dem == soPhanTu) lstTapUngVienTemp.Items.Add(k);
            }
            //Tạo tập ứng viên
            lstTapUngVien.Items.Clear();
            for (int i=0; i < lstTapUngVienTemp.Items.Count; i++)
            {
                int demNgoai = 0;
                String UV=lstTapUngVienTemp.Items[i].ToString();
                String[] k = UV.Split(',');
                for (int j = 0; j < lstTemp.Items.Count;j++)
                {
                    int demTrong = 0;
                    String[] t = lstTemp.Items[j].ToString().Split(',');
                    foreach(String e in k)
                        foreach (String f in t)
                        {
                            if (e != "" && f != "")
                                if (String.Compare(e, f) == 0) demTrong++;
                        }
                    if (demTrong == t.Count() - 1) demNgoai++;
                }
                if (demNgoai == k.Count() - 1) lstTapUngVien.Items.Add(UV);
            }
            xoaPhanTuGiongNhau(lstTapUngVien);

        }
        public void timTapCon(ListBox lstTapCha, ListBox lstTapCon)
        {
            for (int i = 0; i < lstTapCha.Items.Count - 1; i++)
            {
                String t = lstTapCha.Items[i].ToString();
                for (int j = i + 1; j < lstTapCha.Items.Count; j++)
                {
                    String k = lstTapCha.Items[j].ToString();
                    lstTapCon.Items.Add(xoaPhanTuGiongNhau(t+k));
                }
            }
        }
        public void xoaPhanTuGiongNhau(ListBox lstTapUngVien)
        {
            ListBox lstTemp = new ListBox();
            for (int i = 0; i < lstTapUngVien.Items.Count; i++)
            {
                lstTemp.Items.Add(lstTapUngVien.Items[i].ToString());
            }
            for (int i = 0; i < lstTemp.Items.Count - 1; i++)
            {
                String[] k = lstTemp.Items[i].ToString().Split(',');
                for (int j = i + 1; j < lstTemp.Items.Count; j++)
                {
                    int demTrong = 0;
                    String UV = lstTemp.Items[j].ToString();
                    String[] t = UV.Split(',') ;
                    foreach (String e in k)
                        foreach (String f in t)
                            if (e != "" && f != "")
                                if (String.Compare(e, f) == 0)
                                {
                                    demTrong++;
                                    break;
                                }
                    if (demTrong == t.Count() - 1) lstTapUngVien.Items.Remove(UV);
                }
                
            }
        }
        public String xoaPhanTuGiongNhau(String s)
        {
            int Flag = 0;
            String[] str=s.Split(',');
            ListBox lst = new ListBox();
            foreach (String i in str)
            {
                if (i != "") lst.Items.Add(i);
            }
            while (Flag == 0)
            {
                String giaTriTrung = "";
                if (lst.Items.Count==1) break;
                else
                {
                    for (int i = 0; i < lst.Items.Count - 1; i++)
                    {
                        for (int j = i + 1; j < lst.Items.Count; j++)
                        {
                            String t = lst.Items[i].ToString();
                            String k = lst.Items[j].ToString();
                            if (String.Compare(t, k) == 0)
                            {
                                giaTriTrung = t;
                                break;
                            }

                        }
                        if (giaTriTrung != "") break;
                    }
                }
                if (giaTriTrung != "")
                {
                    lst.Items.Remove(giaTriTrung);
                }
                else
                {
                    Flag = 1;
                }
            }
            s = "";
            for (int i = 0; i < lst.Items.Count; i++)
                s += lst.Items[i].ToString() + ",";
            return s;
        }
        public void taoTapLuat(String PTPB, List<Luat> lstLuat)
        {
            String[] s = PTPB.Split(',');
            String[] sTemp = PTPB.Split(',');
            foreach (String i in s)
            {
                if (i != "")
                {
                    Luat Luat1 = new Luat();
                    Luat Luat2 = new Luat();
                    Luat1.veTrai = i + ",";
                    Luat2.vePhai = i + ",";
                    String str = "";
                    foreach (String j in sTemp)
                        if (j != "")
                            if (String.Compare(i, j) != 0)
                                str += j + ",";
                    Luat1.vePhai = str;
                    Luat2.veTrai = str;
                    if (lstLuat.Count == 0)
                    {
                        lstLuat.Add(Luat1);
                        lstLuat.Add(Luat2);
                    }
                    else
                    {
                        int dem1 = 0, dem2 = 0;
                        foreach (Luat k in lstLuat)
                        {
                            if ((String.Compare(k.veTrai, Luat1.veTrai) == 0) && (String.Compare(k.vePhai, Luat1.vePhai) == 0))
                                dem1++;
                            if ((String.Compare(k.veTrai, Luat2.veTrai) == 0) && (String.Compare(k.vePhai, Luat2.vePhai) == 0))
                                dem2++;
                            if (dem1 != 0 && dem2 != 0) break;
                        }
                        if (dem1 == 0) lstLuat.Add(Luat1);
                        if (dem2 == 0) lstLuat.Add(Luat2);
                    }
                }
            }
        }
        public Double tinhSupp(Luat L, ListBox lstHD,int soBoDuLieu)
        {
            Double Supp = 0;
            Double soLanXuatHien = 0;
            String duLieu = "";
            if (String.Compare(L.vePhai, L.veTrai) == 0)
                duLieu = L.veTrai;
            else
                duLieu = L.veTrai + L.vePhai;
            soLanXuatHien = demLanXuatHien(duLieu, lstHD);
            Supp = Math.Round(soLanXuatHien / (Double)soBoDuLieu, 2);
            return Supp;
        }
        public Double tinhConf(Luat L, ListBox lstHD, int soBoDuLieu)
        {
            Double Conf = 0;
            Double Supp1 = 0;
            Double Supp2 = 0;
            Supp1 = tinhSupp(L, lstHD, soBoDuLieu);
            Luat lTemp = new Luat();
            lTemp.vePhai = L.veTrai;
            lTemp.veTrai = L.veTrai;
            Supp2 = tinhSupp(lTemp, lstHD, soBoDuLieu);
            Conf = Math.Round(Supp1 / Supp2, 2);
            return Conf;
        }
        public void Procedure2(List<Luat> tapLuat, ListBox lstMaHD, int soBoDuLieu)
        {
            foreach (Luat L in tapLuat)
            {
                L.Supp = tinhSupp(L, lstMaHD, soBoDuLieu);
                L.Conf = tinhConf(L, lstMaHD, soBoDuLieu);
            }
        }
        public void themTen(List<Luat> tapLuat)
        {
            DataTable dtSP = exeSelect("select masp,tensp from sanpham", "sanpham");
            foreach (Luat L in tapLuat)
            {
                String[] veTrai = L.veTrai.Split(',');
                String[] vePhai = L.vePhai.Split(',');
                String tenVeTrai = "";
                String tenVePhai = "";
                foreach (String i in veTrai)
                {
                    if (i != "")
                    {
                        for (int j = 0; j < dtSP.Rows.Count; j++)
                        {
                            DataRow dtR = dtSP.Rows[j];
                            String maSP = dtR["masp"].ToString();
                            String tenSP = dtR["tensp"].ToString();
                            if (String.Compare(i, maSP) == 0)
                            {
                                tenVeTrai += tenSP + ",";
                                break;
                            }
                        }
                    }
                }
                L.tenVeTrai = tenVeTrai;
                foreach (String i in vePhai)
                {
                    if (i != "")
                    {
                        for (int j = 0; j < dtSP.Rows.Count; j++)
                        {
                            DataRow dtR = dtSP.Rows[j];
                            String maSP = dtR["masp"].ToString();
                            String tenSP = dtR["tensp"].ToString();
                            if (String.Compare(i, maSP) == 0)
                            {
                                tenVePhai += tenSP + ",";
                                break;
                            }
                        }
                    }
                }
                L.tenVePhai = tenVePhai;
            }
        }
    }
}
