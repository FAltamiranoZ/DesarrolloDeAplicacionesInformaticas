package com.example.dai.ejemplobasesdatos;

import android.content.ContentValues;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

public class Apellido extends AppCompatActivity {

    private EditText ape;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_apellido);
        ape= (EditText) findViewById(R.id.etApellido);
        Intent intent = getIntent();
        String message = intent.getStringExtra(MainActivity.EXTRA_MESSAGE);
        String res = message.toString();
    }

    public void agregarApellido(View v){
        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, "administracion",null,1);
        SQLiteDatabase bd = admin.getWritableDatabase();
        String apellido= ape.getText().toString();
        String cu= cv.getText().toString();//?
        ContentValues registro = new ContentValues();
        registro.put("nombre",nombre);
    }
}
