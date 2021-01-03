package com.example.dai.ejemplobasesdatos;

import android.content.ContentValues;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;


import static android.provider.AlarmClock.EXTRA_MESSAGE;

public class MainActivity extends AppCompatActivity {

    private EditText nom, car, uni, cv;
    public static final String EXTRA_MESSAGE = "com.example.myfirstapp.MESSAGE";
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        nom= (EditText)findViewById(R.id.etNombre);
        car=(EditText) findViewById(R.id.etCarrera);
        uni=(EditText) findViewById(R.id.etUniversidad);
        cv= (EditText) findViewById(R.id.etClaveUnica);
    }

    public void limpia(View v){
        cv.setText("");
        nom.setText("");
        car.setText("");
        uni.setText("");
    }

    public void alta (View v){
        String clave, nombre, carrera, universidad;
        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, "administracion",null,1);
        SQLiteDatabase bd = admin.getWritableDatabase();
        clave=cv.getText().toString();
        nombre= nom.getText().toString();
        carrera= car.getText().toString();
        universidad = uni.getText().toString();
        ContentValues registro = new ContentValues();
        registro.put("cu",clave);
        registro.put("nombre",nombre);
        registro.put("carrera",carrera);
        registro.put("universidad", universidad);
        bd.insert("alumnos",null,registro);
        bd.close();
        limpia(v);
        Toast.makeText(this, "se cargaron los datos de la persona",Toast.LENGTH_LONG).show();
    }

    public void consulta(View v){
        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, "administracion",null,1);
        SQLiteDatabase bd = admin.getWritableDatabase();
        //Recuperar la clave única
        String cu= cv.getText().toString();
        //Seleccionas la clave
        Cursor fila=bd.rawQuery("select nombre, carrera, universidad from alumnos where cu="+cu,null);
        //Mostramos resultados
        if(fila.moveToFirst()){
            nom.setText(fila.getString(0));
            car.setText(fila.getString(1));
            uni.setText(fila.getString(2));
        }
        else{
            Toast.makeText(this, "No existe esta clave única", Toast.LENGTH_SHORT).show();
        }
        bd.close();
    }

    public void baja(View v){
        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, "administracion",null,1);
        SQLiteDatabase bd = admin.getWritableDatabase();
        String cu=cv.getText().toString();
        int cant=bd.delete("alumnos", "cu="+cu, null);
        bd.close();

        if(cant==1){
            Toast.makeText(this, "Se borro a la persona con la clave", Toast.LENGTH_LONG).show();
        }
        else{
            Toast.makeText(this, "No se pudo dar de baja", Toast.LENGTH_SHORT).show();
        }
        limpia(v);
    }

    public void modificacion(View v){
        String clave, nombre, carrera, universidad;
        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, "administracion",null,1);
        SQLiteDatabase bd = admin.getWritableDatabase();
        clave=cv.getText().toString();
        nombre= nom.getText().toString();
        carrera= car.getText().toString();
        universidad = uni.getText().toString();
        ContentValues registro = new ContentValues();
        registro.put("nombre",nombre);
        registro.put("carrera",carrera);
        registro.put("universidad", universidad);
        int cant = bd.update("alumnos", registro, "cu="+clave,null);
        bd.close();
        if(cant==1){
            Toast.makeText(this, "Se modificaron los datos", Toast.LENGTH_LONG).show();
        }
        else{
            Toast.makeText(this, "No se modificaron", Toast.LENGTH_SHORT).show();
        }
    }

    public void sendMessage(View v) {
        Intent intent = new Intent(this, Apellido.class);
        EditText editText = (EditText) findViewById(R.id.editText);
        String message = cv.getText().toString();
        intent.putExtra(EXTRA_MESSAGE, message);
        startActivity(intent);
    }


}