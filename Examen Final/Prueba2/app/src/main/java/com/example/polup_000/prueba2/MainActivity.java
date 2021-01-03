package com.example.polup_000.prueba2;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.webkit.WebView;
import android.widget.Button;
import android.widget.EditText;
import android.widget.GridView;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {
    private EditText eT;
    private WebView wV;
    private GridView gV;
    private TextView tV;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        eT = (EditText)findViewById(R.id.eT1);
        wV = (WebView)findViewById(R.id.wV1);
        gV = (GridView)findViewById(R.id.gV1);
        tV = (TextView)findViewById(R.id.tV2);
        wV.getSettings().setJavaScriptEnabled(true);
        wV.loadUrl("http://bahidora.com/");
        gV.setAdapter(new ImageAdapter(this));
    }

    public void metodo1(View v){
        Intent Int1 = new Intent(MainActivity.this,Main2Activity.class);
        Bundle b = new Bundle();
        b.putString("nombre", eT.getText().toString());
        b.putString("nombre2", tV.getText().toString());
        Int1.putExtras(b);
        startActivity(Int1);
    }

}
