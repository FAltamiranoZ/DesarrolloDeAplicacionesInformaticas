package com.example.dai.afinal;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

public class Main2Activity extends AppCompatActivity {

    EditText et;
    Bundle b;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main2);
        b = this.getIntent().getExtras();
        et= (EditText)findViewById(R.id.eT1);
    }

    public void cambio(View v){
        Intent int1 = new Intent(Main2Activity.this, Main3Activity.class);
        b.putString("Apellido", et.getText().toString());
        int1.putExtras(b);
        startActivity(int1);
    }
}
