import React from 'react';

interface EscolherPetshop {
    data: string,
    quantCaesPequenos: Int16Array,
    quantCaesGrandes: Int16Array
}

const FormPetshop = (prop: EscolherPetshop) =>{
    
     //const { addTodo } = prop;

    const onSubmit = (data: EscolherPetshop, e: any) => {
        //addTodo(data.title);
        e.target.reset();
        window.location.href = '/';
    }

    return (
        <div>
            
        </div>
    );
}

export default FormPetshop;