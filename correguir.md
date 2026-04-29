# ✅ Checklist de correcciones (Security Application)

---

## 1. Corregir mapeos equivocados en AutoMapper

**Estado:** Pendiente

**Dónde:**

* SecurityMappingProfile.cs:19
* SecurityMappingProfile.cs:20
* SecurityMappingProfile.cs:22

**Cómo:**

* Reemplazar mapeos de `Role` hacia `RoleResponseDto`.
* Reemplazar mapeos de `RoleRequestDto` hacia `Role`.
* Reemplazar mapeos de `RolUser` hacia `RolUserResponseDto`.
* Revisar que no exista ningún mapeo `Role` o `RolUser` hacia `UserResponseDto`.

**Por qué:**
Evita respuestas incorrectas, errores de conversión y comportamiento inesperado cuando expongas endpoints de Roles y RolUser.

---

## 2. Unificar PersonService con su interfaz

**Estado:** Pendiente

**Dónde:**

* IPersonService.cs:6
* PersonService.cs:9

**Cómo:**

* Renombrar la clase `PersonServices` a `PersonService`.
* Hacer que implemente `IPersonService`.
* Confirmar que la firma de métodos coincide exactamente con la interfaz.
* Registrar el servicio en DI (igual que hiciste con usuario).

**Por qué:**
Mantiene consistencia arquitectónica, facilita pruebas y habilita inyección por contrato.

---

## 3. Inyectar interfaz en el controller (no clase concreta)

**Estado:** Pendiente

**Dónde:**

* UserController.cs:12
* UserController.cs:15
* Program.cs:12

**Cómo:**

* Cambiar dependencia privada de `UserService` a `IUserService`.
* Cambiar constructor para recibir `IUserService`.
* Mantener el registro `AddScoped<IUserService, UserService>()`.

**Por qué:**
Reduce acoplamiento y permite cambiar implementación sin tocar el controller.

---

## 4. Corregir namespace de RolUserResponseDto

**Estado:** Pendiente

**Dónde:**

* RolUserResponseDto.cs:3

**Cómo:**

* Cambiar namespace a:

  ```
  Somnguard.Backend.Security.application.Dto.ResponseDto
  ```
* Verificar que los `using` y referencias compilen.

**Por qué:**
Evita errores silenciosos de resolución de tipos al usar ese DTO.

---

## 5. Agregar control de no encontrado en Update/Get

**Estado:** Pendiente

**Dónde:**

* UserService.cs:43
* PersonService.cs:40
* UserService.cs:22
* PersonService.cs:23

**Cómo:**

* Validar si `existing` o entidad es `null`.
* Si es `null`, lanzar excepción de negocio o devolver resultado controlado.
* Hacer que el controller traduzca eso a **404**.

**Por qué:**
Evita `null reference` y hace que la API responda correctamente cuando el id no existe.

---

## 6. Dejar de guardar password plano

**Estado:** ⚠️ Pendiente crítica

**Dónde:**

* UserService.cs:46

**Cómo:**

* Introducir un servicio de hash (por ejemplo `IPasswordHasher`).
* Hashear al crear usuario.
* Hashear al actualizar password.
* Nunca devolver password en response DTO (ya vas bien ahí).

**Por qué:**
Es un requisito de seguridad básico. Guardar password plano es un riesgo grave.

---

## 7. Limpieza de naming en DTO request

**Estado:** Recomendado

**Dónde:**

* UserRequestDto.cs:1

**Cómo:**

* Renombrar carpeta y namespace de `RequesDto` a `RequestDto`.
* Ajustar `using` en servicios, mappings y controllers.

**Por qué:**
Evita deuda técnica y confusiones futuras en imports.

---

# 🚀 Orden sugerido de ejecución

1. Mapeos
2. Namespace DTO
3. PersonService + interfaz
4. Inyección por interfaz
5. Null / Not Found
6. Hash password
7. Naming

---

# ✔️ Criterio de cierre por ítem

* Compila sin errores.
* Endpoint relacionado responde correctamente en caso exitoso y no encontrado.
* No se exponen datos sensibles.
* El contrato interfaz/implementación queda consistente.

---
