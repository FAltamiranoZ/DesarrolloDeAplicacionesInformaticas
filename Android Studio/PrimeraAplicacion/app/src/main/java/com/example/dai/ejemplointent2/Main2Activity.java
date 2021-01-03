package com.example.dai.ejemplointent2;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class Main2Activity extends AppCompatActivity {
    private TextView tvNombre;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main2);
        tvNombre=(TextView)findViewById(R.id.tvNombre);
        Bundle bundle = this.getIntent().getExtras();//Recupera el intent
        tvNombre.setText("Hola: "+bundle.get("Nombre"));//Poner el nombre de lo que mandé


    }
}
