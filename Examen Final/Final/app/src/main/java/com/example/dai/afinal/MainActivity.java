package com.example.dai.afinal;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

public class MainActivity extends AppCompatActivity {

    EditText et;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        et= (EditText)findViewById(R.id.eT1);
    }

    public void cambio(View v){
        Intent int1 = new Intent(MainActivity.this, Main2Activity.class);
        Bundle b = new Bundle();
        b.putString("Nombre", et.getText().toString());
        int1.putExtras(b);
        startActivity(int1);
    }

}
