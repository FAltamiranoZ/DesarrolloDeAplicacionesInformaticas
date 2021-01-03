package com.example.dai.fragmentosejemplo;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.SQLException;
import android.database.sqlite.SQLiteDatabase;

/**
 * Created by dai on 07/12/2017.
 */

public class InterfazBD {

    ConexionBD con;
    SQLiteDatabase db;

    public InterfazBD (Context context){
        con = new ConexionBD(context);
    }

    public void open() throws SQLException{
        db = con.getWritableDatabase();
    }

    public void close() throws  SQLException{
        con.close();
    }

    public long insertarDatos(String dato){
        ContentValues valores;
        open();
        valores = new ContentValues();
        valores.put("datos",dato);
        long clave = db.insert("tablaDatos", null, valores);
        close();
        return clave;
    }

    public void insertarDatosIni(){
        ContentValues valores;
        open();
        valores = new ContentValues();
        valores.put("datos", "hola");
        db.insert("tablaDatos", null, valores);
        valores.put("datos", "adios");
        db.insert("tablaDatos", null, valores);
    }

    public String traerDato (long clave){
        open();
        String claveString = Long.toString(clave);
        String query = "select * from tablaDatos where id = "+claveString;
        Cursor c = db.rawQuery(query, null);
        c.moveToNext();
        String res = c.getString(1);
        c.close();
        close();
        return res;
    }

    public Cursor traerDatos(){
        Cursor res = null;
        open();
        String query = "select * from tablaDatos";
        res=db.rawQuery(query, null);
        if (res.getCount()==0){
            insertarDatosIni();
            res = db.rawQuery(query, null);
        }
        return res;
    }



}
