import React from 'react';
import { Petshop } from '../models/Petshop';


const PetshopList = () =>{
    const petshops: Petshop[] = [
        { id:1, nome: 'Meu Canino Feliz', distancia: 2000, vlBanhoDiasUteisCaesPequenos:20, vlBanhoDiasUteisCaesGrandes: 40, vlBanhoFDSCaesPequenos: 20*0.2+20, vlBanhoFDSCaesGrandes: 40*0.2+40},
        { id:2, nome: 'Vai Rex', distancia: 1700, vlBanhoDiasUteisCaesPequenos:15, vlBanhoDiasUteisCaesGrandes: 50, vlBanhoFDSCaesPequenos: 20, vlBanhoFDSCaesGrandes: 55},
        { id:3, nome: 'ChowChawgas', distancia: 800, vlBanhoDiasUteisCaesPequenos:30, vlBanhoDiasUteisCaesGrandes: 45, vlBanhoFDSCaesPequenos: 30, vlBanhoFDSCaesGrandes: 45}
    ];

    return(
    <div>
        Lista de Petshops
        <br></br>
        {petshops[0].nome}
    </div>
    );
}
export default PetshopList;
