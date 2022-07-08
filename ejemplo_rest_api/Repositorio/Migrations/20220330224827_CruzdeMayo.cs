using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositorio.Migrations
{
    public partial class CruzdeMayo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    id_cargo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    des_cargo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.id_cargo);
                });

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Laboratorio",
                columns: table => new
                {
                    idlaboratorio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    direccion = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    razonsocial = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    representante = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    celular = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laboratorio", x => x.idlaboratorio);
                });

            migrationBuilder.CreateTable(
                name: "Presentacion",
                columns: table => new
                {
                    idpresentacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    presentacion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presentacion", x => x.idpresentacion);
                });

            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    idproveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    razonsocial = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ruc = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    celular = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    representante = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedor", x => x.idproveedor);
                });

            migrationBuilder.CreateTable(
                name: "Sucursal",
                columns: table => new
                {
                    idsucursal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    direccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    celular = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    representante = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursal", x => x.idsucursal);
                });

            migrationBuilder.CreateTable(
                name: "persona",
                columns: table => new
                {
                    idPersona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    apellido_paterno = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    apellido_materno = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    gmail = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    DNI = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false),
                    idcargo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persona", x => x.idPersona);
                    table.ForeignKey(
                        name: "FK_persona_Cargo_idcargo",
                        column: x => x.idcargo,
                        principalTable: "Cargo",
                        principalColumn: "id_cargo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medicamento",
                columns: table => new
                {
                    idmedicamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    medicamento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    concentracion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    stock = table.Column<int>(type: "int", nullable: false),
                    precio = table.Column<double>(type: "float", nullable: false),
                    fechaingreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechavencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false),
                    id_categoria = table.Column<int>(type: "int", nullable: false),
                    id_presentacion = table.Column<int>(type: "int", nullable: false),
                    id_laboratorio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicamento", x => x.idmedicamento);
                    table.ForeignKey(
                        name: "FK_Medicamento_Categoria_id_categoria",
                        column: x => x.id_categoria,
                        principalTable: "Categoria",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medicamento_Laboratorio_id_laboratorio",
                        column: x => x.id_laboratorio,
                        principalTable: "Laboratorio",
                        principalColumn: "idlaboratorio",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medicamento_Presentacion_id_presentacion",
                        column: x => x.id_presentacion,
                        principalTable: "Presentacion",
                        principalColumn: "idpresentacion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Salida",
                columns: table => new
                {
                    idsalidas = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    serie = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    numero = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    total = table.Column<double>(type: "float", nullable: false),
                    id_sucursal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salida", x => x.idsalidas);
                    table.ForeignKey(
                        name: "FK_Salida_Sucursal_id_sucursal",
                        column: x => x.id_sucursal,
                        principalTable: "Sucursal",
                        principalColumn: "idsucursal",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entradas",
                columns: table => new
                {
                    identradas = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    total = table.Column<double>(type: "float", nullable: false),
                    NumeroCompra = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    subtotal = table.Column<double>(type: "float", nullable: false),
                    id_proveedor = table.Column<int>(type: "int", nullable: false),
                    id_persona = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entradas", x => x.identradas);
                    table.ForeignKey(
                        name: "FK_Entradas_persona_id_persona",
                        column: x => x.id_persona,
                        principalTable: "persona",
                        principalColumn: "idPersona",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entradas_Proveedor_id_proveedor",
                        column: x => x.id_proveedor,
                        principalTable: "Proveedor",
                        principalColumn: "idproveedor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_persona = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.id);
                    table.ForeignKey(
                        name: "FK_usuario_persona_id_persona",
                        column: x => x.id_persona,
                        principalTable: "persona",
                        principalColumn: "idPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleSalida",
                columns: table => new
                {
                    iddetallesalida = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    total = table.Column<double>(type: "float", nullable: false),
                    id_medicamento = table.Column<int>(type: "int", nullable: false),
                    id_salida = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleSalida", x => x.iddetallesalida);
                    table.ForeignKey(
                        name: "FK_DetalleSalida_Medicamento_id_medicamento",
                        column: x => x.id_medicamento,
                        principalTable: "Medicamento",
                        principalColumn: "idmedicamento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleSalida_Salida_id_salida",
                        column: x => x.id_salida,
                        principalTable: "Salida",
                        principalColumn: "idsalidas",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleEntrada",
                columns: table => new
                {
                    iddetalleentradas = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    id_medicamento = table.Column<int>(type: "int", nullable: false),
                    id_entrada = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleEntrada", x => x.iddetalleentradas);
                    table.ForeignKey(
                        name: "FK_DetalleEntrada_Entradas_id_entrada",
                        column: x => x.id_entrada,
                        principalTable: "Entradas",
                        principalColumn: "identradas",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleEntrada_Medicamento_id_medicamento",
                        column: x => x.id_medicamento,
                        principalTable: "Medicamento",
                        principalColumn: "idmedicamento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetalleEntrada_id_entrada",
                table: "DetalleEntrada",
                column: "id_entrada");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleEntrada_id_medicamento",
                table: "DetalleEntrada",
                column: "id_medicamento");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleSalida_id_medicamento",
                table: "DetalleSalida",
                column: "id_medicamento");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleSalida_id_salida",
                table: "DetalleSalida",
                column: "id_salida");

            migrationBuilder.CreateIndex(
                name: "IX_Entradas_id_persona",
                table: "Entradas",
                column: "id_persona");

            migrationBuilder.CreateIndex(
                name: "IX_Entradas_id_proveedor",
                table: "Entradas",
                column: "id_proveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Medicamento_id_categoria",
                table: "Medicamento",
                column: "id_categoria");

            migrationBuilder.CreateIndex(
                name: "IX_Medicamento_id_laboratorio",
                table: "Medicamento",
                column: "id_laboratorio");

            migrationBuilder.CreateIndex(
                name: "IX_Medicamento_id_presentacion",
                table: "Medicamento",
                column: "id_presentacion");

            migrationBuilder.CreateIndex(
                name: "IX_persona_idcargo",
                table: "persona",
                column: "idcargo");

            migrationBuilder.CreateIndex(
                name: "IX_Salida_id_sucursal",
                table: "Salida",
                column: "id_sucursal");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_id_persona",
                table: "usuario",
                column: "id_persona");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleEntrada");

            migrationBuilder.DropTable(
                name: "DetalleSalida");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "Entradas");

            migrationBuilder.DropTable(
                name: "Medicamento");

            migrationBuilder.DropTable(
                name: "Salida");

            migrationBuilder.DropTable(
                name: "persona");

            migrationBuilder.DropTable(
                name: "Proveedor");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Laboratorio");

            migrationBuilder.DropTable(
                name: "Presentacion");

            migrationBuilder.DropTable(
                name: "Sucursal");

            migrationBuilder.DropTable(
                name: "Cargo");
        }
    }
}
