## 📖 Descripción del Proyecto

Este proyecto es una aplicación de consola desarrollada en **C#** que simula el sistema de gestión de una biblioteca universitaria. Permite registrar, prestar y devolver materiales bibliográficos, diferenciando las reglas de negocio entre **Libros Físicos** y **Libros Digitales**.

El objetivo principal de este sistema es aplicar correctamente los cuatro pilares fundamentales de la Programación Orientada a Objetos (POO).

---

## 🛠️ Pilares de la POO Aplicados

1. **Abstracción:** Se implementó una clase base abstracta `MaterialBiblioteca` que define la estructura y el comportamiento general de cualquier material, impidiendo su instanciación directa.
2. **Encapsulamiento:** Se protegieron los atributos de las clases utilizando modificadores de acceso (`private`, `protected`) y propiedades (`get`, `set`) para garantizar la integridad de los datos (ej. el código único autogenerado y el estado del préstamo).
3. **Herencia:** Las clases `LibroFisico` y `LibroDigital` heredan los atributos y métodos de la clase base `MaterialBiblioteca`, extendiendo su funcionalidad con características propias (número de ejemplar y tamaño en MB, respectivamente).
4. **Polimorfismo:** Se sobrescribieron (`override`) los métodos virtuales `Prestar()` y `MostrarInformacion()` en las clases hijas para que cada tipo de libro aplique sus propias reglas (préstamos de 7 días vs 3 días).

---

## ⚙️ Requisitos y Ejecución

* **Lenguaje:** C# (.NET)
* **Entorno:** Aplicación de Consola

**Instrucciones de ejecución:**
1. Clonar este repositorio:
   ```bash
   git clone [https://github.com/](https://github.com/)[TuUsuario]/IPC2_Practica1_[TuCarnet].git
2. Abrir el proyecto en Visual Studio o Visual Studio Code.

3. Compilar y ejecutar el archivo Program.cs.
