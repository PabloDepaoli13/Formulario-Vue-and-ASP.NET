<template>
  <div v-if="cargando">
      <p>Cargando...</p>
  </div>
  <div v-if="contrato == 'Vacio'">
    <div class="container mt-5">
        <div class="row justify-content-center">
          <div class="col-md-12">
            <div class="card">
              <div class="card-body">
                <h5 class="card-title">Detalles del contrato</h5>
                <ul class="list-group">
                  <li class="list-group-item"><strong>"El contrato no se encontró. Por favor, asegúrese de que el número pertenezca a un contrato válido e inténtelo nuevamente."</strong></li>
                </ul>
              </div>
            </div>
          </div>
        </div>
      </div>
  </div>
  <div v-if="contrato !== null && contrato !== 'Vacio'">
  <div class="container mt-5">
  <div class="row justify-content-center">
    <div class="col-md-12">
      <div class="card">
        <div class="card-body">
          <h5 class="card-title">Detalles del contrato</h5>
          <ul class="list-group">
            <li class="list-group-item"><strong>Código:</strong> {{ contrato.status }}</li>
            <li class="list-group-item"><strong>Código del Curso:</strong> {{ contrato.courseCode }}</li>
            <li class="list-group-item"><strong>Fecha de Alta:</strong> {{contrato.fechaAlta  }}</li>
            <li class="list-group-item"><strong>Colegio Nivel:</strong> {{contrato.colegioNivel}} </li>
            <li class="list-group-item"><strong>Nombre del Colegio:</strong> {{contrato.colegioNombre}}</li>
            <li class="list-group-item"><strong>Curso del Colegio:</strong> {{contrato.colegioCurso}} </li>
            <li class="list-group-item"><strong>Localidad del Colegio:</strong>{{contrato.colegioLocalidad}}</li>
            <li class="list-group-item" v-for="(request, index) in contrato.requests" :key="index">
              <strong>Pedidos:</strong>
              <ul>
                <li>Cantidad: {{ request.cantidadEgresados }}</li>
                <li>Articulo: {{ request.articulo }}</li>
                <li>Precio Unitario: ${{ request.precioUnitario }}</li>
                <li>Total: ${{ request.totalArticulo }}</li>
              </ul>
            </li>
            <li class="list-group-item"><strong>Total: </strong> ${{ contrato.total }} </li>
            <li class="list-group-item"><strong>Fecha de Entrega:</strong> {{ contrato.fechaEntrega }} </li>
          </ul>
          </div>
        </div>
      </div>
    </div>
  </div>
</div>

</template>

<script>
  export default {
    name: "orderComponent",
    props: ["contrato", "cargando"],
    data() {
      return {
        error: null,
      };
    },
    watch: {
      contract() {
        if (contrato.status == 404) {
          this.error = true;
        } else {
          this.error = false;
        }
      },
    },
  };
</script>