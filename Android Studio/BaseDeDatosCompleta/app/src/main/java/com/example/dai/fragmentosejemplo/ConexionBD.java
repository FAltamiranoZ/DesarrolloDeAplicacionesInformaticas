package com.example.dai.fragmentosejemplo;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

/**
 * Created by dai on 07/12/2017.
 */

public class ConexionBD extends SQLiteOpenHelper{
    String cadena = "create tabla if not exists tablaDatos (id integer primary key autoincrement, datos text not null)";

    public ConexionBD (Context context){//Esto es un this basicamente
        super(context, "prueba.db", null, 1);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {//Al crearse
        db.execSQL(cadena);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {//Al irte de la actividad y regresar
        onCreate(db);
    }
}


