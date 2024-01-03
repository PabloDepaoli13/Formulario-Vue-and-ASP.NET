

<template>
  <div class="container mt-2 sm: m-1">
    <div class="grid">
      <div class="row">
        <p class="h3 text-primary m-3">Buscador de Contratos</p>
        <p class="lead m-3">Ingresando el Id del contrato que buscas dentro del buscador podrás acceder a los datos y costo de tu pedido.</p>
            <div class="col-7 m-3">
                <FormComponent @enviarIdContrato="ObtenerContrato"/>
            </div>
        </div>
    </div>  
  </div>
  <div class="container mb-0 mt-0 h-100">
    <div class="grid">
      <div class="row">
            <div class="col">
               <OrderComponent :contrato="contrato" :cargando="cargando"/>
            </div>
        </div>
    </div>  
  </div>
 
</template>

<script>
import OrderComponent from '@/components/orderComponent.vue';
import FormComponent from '@/components/formComponent.vue';
import { ContratoService } from '@/services/conexion';

export default {
  components: {
    OrderComponent,
    FormComponent,
  },
  data() {
    return {
      contrato: null,
      cargando: false,
    };
  },
  methods: {
    async ObtenerContrato(contratoId) {
    if (contratoId) {
      this.cargando = true;
      try {
        const response = await ContratoService.getContrato(contratoId);
        console.log(response);
        if(response.status == 404){
          this.contrato = 'Vacio';
        }else{
          this.contrato = response;
        }
      } catch (error) {
        this.contrato = null;
      } finally {
        this.cargando = false;
      }
    } else{
      this.contrato = null;
      }
    },
  },
};
</script>