package com.example.dai.afinal;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

public class Main5Activity extends AppCompatActivity {

    TextView tV1;
    TextView tV2;
    TextView tV3;
    Bundle b;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main5);
        b = this.getIntent().getExtras();
        tV1 = (TextView)findViewById(R.id.tV1);
        tV2 = (TextView)findViewById(R.id.tV2);
        tV3 = (TextView)findViewById(R.id.tV3);
        tV1.setText(b.getString("Nombre"));
        tV2.setText(b.getString("Apellido"));
        tV3.setText(b.getString("Correo"));
    }

    public void cambio(View v){
        Intent int1 = new Intent(Main5Activity.this, Main6Activity.class);
        startActivity(int1);
    }

    public void vuelta(View v){
        Intent int1 = new Intent(Main5Activity.this, MainActivity.class);
        startActivity(int1);
    }

}
