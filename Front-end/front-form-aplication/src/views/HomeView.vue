<script setup>
//import PageComponent from '@/components/pageComponent.vue';
import OrderComponent from '@/components/orderComponent.vue';
import FormComponent from '@/components/formComponent.vue';
</script>

<template>
  <div class="container mt-2 sm: m-1">
    <div class="grid">
      <div class="row">
        <p class="h3 text-primary m-3">Buscador de Contrato</p>
            <div class="col-7 m-3">
                
                <FormComponent/>
            </div>
        </div>
    </div>  
  </div>
  <div class="container mb-0 mt-0 h-100">
    <div class="grid">
      <div class="row">
            <div class="col">
               <OrderComponent/>
            </div>
        </div>
    </div>  
  </div>
 
</template>
