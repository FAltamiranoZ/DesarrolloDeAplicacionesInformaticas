package com.example.polup_000.prueba2;

import android.content.ContentValues;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class Main2Activity extends AppCompatActivity {
    private TextView tV;
    private TextView tV2;
    private EditText eTcu;
    private EditText eTcarr;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main2);
        tV = (TextView)findViewById(R.id.tV2);
        tV2 = (TextView)findViewById(R.id.tV3);
        eTcu = (EditText)findViewById(R.id.eT2);
        eTcarr = (EditText)findViewById(R.id.eT3);
        Bundle b = this.getIntent().getExtras();
        tV.setText(""+b.get("nombre"));
        tV2.setText("Prueba exitosa"+b.getString("nombre2"));

    }

    public void modificacion(View v){
        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, "administracion",null,1);
        SQLiteDatabase bd = admin.getWritableDatabase();
        String cu = eTcu.getText().toString();
        String carrera = eTcarr.getText().toString();
        ContentValues cV = new ContentValues();
        cV.put("carr", carrera);
        bd.update("prueba", cV, "cu="+cu,null);
        bd.close();
        Toast.makeText(this, "Modificacion exitosa", Toast.LENGTH_SHORT).show();
    }

    public void alta(View v){
        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, "administracion",null,1);
        SQLiteDatabase bd = admin.getWritableDatabase();
        String cu = eTcu.getText().toString();
        String carr = eTcarr.getText().toString();
        ContentValues cv = new ContentValues();
        cv.put("cu", cu);
        cv.put("carr", carr);
        bd.insert("prueba", null, cv);
        Toast.makeText(this, "Alta exitosa", Toast.LENGTH_SHORT).show();
        bd.close();
    }

    public void baja(View v){
        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, "administracion",null,1);
        SQLiteDatabase bd = admin.getWritableDatabase();
        String cu = eTcu.getText().toString();
        int cant=bd.delete("prueba", "cu="+cu, null);
        bd.close();
        if(cant==1){
            Toast.makeText(this, "Baja exitosa", Toast.LENGTH_SHORT).show();
        }
        else {
            Toast.makeText(this, "Baja fallida", Toast.LENGTH_SHORT).show();
        }
    }

    public void consulta(View v){
        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, "administracion",null,1);
        SQLiteDatabase bd = admin.getWritableDatabase();
        String cu = eTcu.getText().toString();
        Cursor fila = bd.rawQuery("select * from prueba where cu="+cu, null);
        if(fila.moveToFirst()){
            eTcu.setText(fila.getString(0));
            eTcarr.setText(fila.getString(1));
        }
        bd.close();
        Toast.makeText(this, "Consulta exitosa", Toast.LENGTH_SHORT).show();
    }


}
