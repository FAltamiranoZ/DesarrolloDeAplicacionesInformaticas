package com.example.dai.fragmentosejemplo;


import android.app.FragmentManager;
import android.app.FragmentTransaction;
import android.os.Bundle;


import android.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;


/**
 * A simple {@link Fragment} subclass.
 */
public class BlankFragment extends android.app.Fragment {

    EditText dato;
    InterfazBD iBD;
    FragmentManager fm;
    public BlankFragment() {
        // Required empty public constructor
    }

    Button agregar;
    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment

        View v =  inflater.inflate(R.layout.fragment_blank, container, false);
        agregar = (Button) v.findViewById(R.id.botonAgregar);
        dato= (EditText) v.findViewById(R.id.datoUsuario);
        fm = this.getActivity().getFragmentManager();

        agregar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String s= dato.getText().toString();
                iBD = new InterfazBD(v.getContext());
                //insertar dato en la bd
                long clave= iBD.insertarDatos(s);
                //mostrar la llave primaria del dato agregado
                Toast.makeText(v.getContext(),"llave es:"+clave, Toast.LENGTH_SHORT).show();
                FragmentTransaction ft= fm.beginTransaction();
                Fragment f1 = new FragmentoListas();
                ft.replace(R.id.actividadPrincipal,f1);
                ft.commit();


            }
        });





        return v;
    }
}