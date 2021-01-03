package com.example.dai.ejemplointent2;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.webkit.WebView;
import android.widget.Button;
import android.widget.EditText;

public class MainActivity extends AppCompatActivity {
    private EditText nombre;
    private Button boton;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        nombre = (EditText)findViewById(R.id.etNombre);//Es la manera de recuperar lo del xml
        boton=(Button)findViewById(R.id.btAceptar);
        String url="http://bahidora.com/";
        WebView webView = (WebView)this.findViewById(R.id.wV);
        webView.getSettings().setJavaScriptEnabled(true);
        webView.loadUrl(url);
        //Todo permiso va en el manifest que está en Project/app/src/main
    }

    public  void aceptar (View v){
        Intent intent = new Intent(MainActivity.this, Main2Activity.class);//Le digo que vaya a la otra página.
        Bundle b = new Bundle();//Le puedo agregar multiples cosas
        b.putString("Nombre", nombre.getText().toString());
        intent.putExtras(b);//Se usa putExtras si es bundle, si no es putExtra
        startActivity(intent);
    }
}
