package Models;

import java.sql.DriverManager;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Hiep
 */

// Hiệp
// Lớp kết nối CSDL, là lớp chỉ có một thể hiện duy nhất
public class DBConnect {
    private Connection Conn;
    private static DBConnect instance;

    private DBConnect(){

    }

    //Hiệp
    //Đảm bảo lớp này chỉ có một thể hiện
    public static DBConnect getInstance(){
            if (instance==null){
                synchronized(DBConnect.class){
                    if (instance==null)
                        instance = new DBConnect();
                }
            }

            return instance;
    }


    //Hiệp
    //Kết nối CSDL
    public void Connect() throws ClassNotFoundException, SQLException{
        if ((Conn == null)||(Conn.isClosed()))
        try{
            String url;
            url="jdbc:oracle:thin:@localhost:1521/orcl";
            DriverManager.registerDriver(new oracle.jdbc.OracleDriver());
            this.Conn = DriverManager.getConnection(url, "bank","bank");
            }
            catch(Exception e){}
        }


    /**
     * @return the Conn
     */
    public Connection getConn() {
        return Conn;
    }

    /**
     * @param Conn the Conn to set
     */
    public void setConn(Connection Conn) {
        this.Conn = Conn;
    }

    public void Close() throws SQLException{
        Conn.close();
    }

    //Hiệp
    //thực hiện câu truy vấn select
    public ResultSet exeSelect(String sql) throws Exception{
        Connect();
        PreparedStatement st = Conn.prepareStatement(sql);
        ResultSet rs = st.executeQuery();
        
        return rs;
    }

    //Hiệp
    //Thực hiện 3 câu insert, update, delete
    public Boolean exeSql(String sql) throws Exception{
        Connect();
        PreparedStatement st = Conn.prepareStatement(sql);
        int rs = st.executeUpdate();
        return rs > 0;
    }
}
