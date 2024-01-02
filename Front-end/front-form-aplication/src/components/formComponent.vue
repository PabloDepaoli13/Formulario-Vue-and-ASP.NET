<script setup>
</script>


<template>
    <div class="card shadow-lg text-center">
      <div class="card-header bg-primary text-white">
          <p class="h3">Buscador</p>
      </div>
      <div class="card-body bg-light">
          <form @submit.prevent="enviarId">
              <div class="mb-2 ">
                  <label for="itemNumber">Numero de contrato</label>
                  <input v-model="contratoId" type="number" min="1">
              </div>
              <div class="mb-2">
                <button class="btn btn-primary">Enviar</button>
              </div>
          </form>
      </div>
    </div>
</template>