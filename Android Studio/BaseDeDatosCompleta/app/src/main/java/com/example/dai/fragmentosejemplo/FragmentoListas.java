package com.example.dai.fragmentosejemplo;


import android.app.Fragment;
import android.app.ListFragment;
import android.database.Cursor;
import android.os.Bundle;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ListView;
import android.widget.SimpleCursorAdapter;


/**
 * A simple {@link Fragment} subclass.
 */
public class FragmentoListas extends ListFragment {

    InterfazBD iBD;//clase donde se maneja la bd
    Cursor res; // lector que tiene los datos de una busqueda
    SimpleCursorAdapter sca; //conexion entre los datos  y el fragmento
    ListView lv;


    public FragmentoListas() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View v = super.onCreateView(inflater, container, savedInstanceState);
        //nombres de las columnas en la bd
        String []arregloColumnas={"_id","datos"};
        //Textviews del renglon donde se guardan los datos
        int []to={R.id.texto1, R.id.texto2};
        //crear la conexion con la base de datos
        iBD = new InterfazBD(this.getActivity());
        //crear el cursor de la bd con los resultados de la tabla
        res= iBD.traerDatos();
        sca=new SimpleCursorAdapter(this.getActivity(),R.layout.formato_renglon,res,arregloColumnas,to,0);
        this.setListAdapter(sca);
        return v;
    }

}
