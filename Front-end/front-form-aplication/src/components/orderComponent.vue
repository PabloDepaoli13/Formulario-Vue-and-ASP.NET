<template>
  <div v-if="cargando">
      <p>Cargando...</p>
  </div>
  <div class="container mt-5" v-if="contrato !== null && !error">
  <div class="row justify-content-center">
    <div class="col-md-12">
      <div class="card">
        <div class="card-body">
          <h5 class="card-title">Objeto</h5>
          <ul class="list-group">
            <li class="list-group-item"><strong>Código del Curso:</strong> Valor 1</li>
            <li class="list-group-item"><strong>Fecha de Alta:</strong> Valor 2</li>
            <li class="list-group-item"><strong>Colegio Nivel:</strong> Valor 1</li>
            <li class="list-group-item"><strong>Nombre del Colegio:</strong> Valor 2</li>
            <li class="list-group-item"><strong>Curso del Colegio:</strong> Valor 1</li>
            <li class="list-group-item"><strong>Localidad del Colegio:</strong> Valor 2</li>
            <li class="list-group-item">
              <strong>Pedidos:</strong>
              <ul>
                <li>Elemento 1</li>
                <li>Elemento 2</li>
                <li>Elemento 1</li>
                <li>Elemento 2</li>
              </ul>
            </li>
            <li class="list-group-item"><strong>Total:</strong> Valor 1</li>
            <li class="list-group-item"><strong>Fecha de Entrega:</strong> Valor 2</li>
          </ul>
        </div>
      </div>
    </div>
  </div>
</div>
  </template>

<script setup>

</script>