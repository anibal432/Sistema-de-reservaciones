# Sistema de Reservación de Canchas Deportivas
## Proyecto B_46509618

---

## PASOS PARA EJECUTAR

### 1. Crear la base de datos
- Abre SQL Server Management Studio (SSMS)
- Abre el archivo `BaseDatos.sql`
- Ejecuta todo el script (F5)
- Verás el mensaje de confirmación con las credenciales

### 2. Verificar la cadena de conexión
- Abre `App.config`
- La cadena por defecto usa `localhost\SQLEXPRESS`
- Si tu instancia tiene otro nombre, cámbiala:
  ```
  Server=TU_SERVIDOR\TU_INSTANCIA;Database=ReservacionCancha;Integrated Security=True;
  ```

### 3. Abrir el proyecto en Visual Studio
- Abre Visual Studio 2019 o 2022
- Archivo → Abrir → Proyecto/Solución
- Selecciona `SistemaReservaciones.csproj`
- Espera que cargue, luego: **Compilar → Recompilar solución**
- Presiona F5 para ejecutar

---

## CREDENCIALES DE LOGIN

| Usuario    | Contraseña   | Rol      |
|------------|--------------|----------|
| admin      | admin123     | Admin    |
| empleado1  | empleado123  | Empleado |

---

## MÓDULOS INCLUIDOS

- **Login** — Autenticación de empleados
- **Tipos de Cancha** — CRUD (Futbol, Tenis, Basquet)
- **Canchas** — CRUD con precio y estado activo/inactivo
- **Clientes** — CRUD con DPI único
- **Horarios** — CRUD de turnos fijos (HH:mm)
- **Nueva Reserva** — Crea reserva con validación de doble reserva
- **Ver Reservas** — Lista todas las reservas, permite cancelar

---

## NOTAS
- El monto se llena automáticamente al seleccionar la cancha
- El sistema bloquea reservas duplicadas (misma cancha + fecha + horario)
- Los horarios se ingresan en formato HH:mm (ej: 08:00, 14:30)
