<p align="center">
  <b>Projeto desenvolvido em Unity 2017.1.1f1</b><br>
  Trabalho acadêmico baseado no tutorial oficial <i>Survival Shooter</i> da Unity.
</p>

---

## 📖 Sobre o Projeto

Survival Shooter é um jogo de sobrevivência onde o jogador deve enfrentar ondas de inimigos, acumular pontos e sobreviver o maior tempo possível.

Durante o desenvolvimento foram implementados sistemas fundamentais de jogos, incluindo gerenciamento de vida, pontuação, combate, interface gráfica e controle de áudio.

---

## ✨ Funcionalidades

* ✅ Menu Inicial
* ✅ Sistema de Pontuação
* ✅ Sistema de Vida
* ✅ Sistema de Pause
* ✅ Controle de Áudio
* ✅ Spawn de Inimigos
* ✅ Sistema de Combate
* ✅ Game Over

---

## 🎯 Controles

| Ação         | Tecla           |
| ------------ | --------------- |
| Movimentação | WASD            |
| Mirar        | Mouse           |
| Atirar       | Clique Esquerdo |
| Pausar       | ESC             |
| Correr       | Shift           |

---

## 🖼️ Capturas de Tela

### Menu Inicial

<img width="763" height="431" alt="image" src="https://github.com/user-attachments/assets/d981e94c-ec40-469b-bcbc-5f5058c99968" />

### Gameplay

<img width="956" height="406" alt="image" src="https://github.com/user-attachments/assets/e51cf4d2-022a-4985-99f0-28f8a55a8698" />

### GameOver
<img width="956" height="403" alt="image" src="https://github.com/user-attachments/assets/7573a16e-d814-418c-a5f2-22718be56119" />

---

🔧 Funcionalidades Desenvolvidas
1. Sistema de Cura (Health Pack)

Foi desenvolvido um sistema de cura através da coleta de itens especiais espalhados pelo mapa. Ao entrar em contato com o item, o jogador recupera parte da sua vida, aumentando suas chances de sobrevivência durante as ondas de inimigos.

Trecho de código utilizado:

private void OnTriggerEnter(Collider other)
{
    PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

    if(playerHealth != null)
    {
        playerHealth.Heal(healAmount);
        Destroy(gameObject);
    }
}

<img width="918" height="284" alt="image" src="https://github.com/user-attachments/assets/895f0144-96c2-4f08-b22d-4ae0fce4ee8d" />

2. Sistema de Corrida (Sprint)

Foi implementado um sistema de corrida que permite ao jogador aumentar temporariamente sua velocidade ao pressionar a tecla Shift. Essa funcionalidade melhora a mobilidade do personagem durante a partida.

Trecho de código utilizado:

float currentSpeed = Input.GetKey(KeyCode.LeftShift)
    ? runSpeed
    : walkSpeed;

movement.Set(h, 0, v);
movement = movement.normalized * currentSpeed * Time.deltaTime;

<img width="935" height="152" alt="image" src="https://github.com/user-attachments/assets/5a45b90d-d5c0-4bb0-aee9-26e005cc666d" />

---
## 🎥 Vídeo de Demonstração

Assista à gameplay completa do projeto:

👉 https://drive.google.com/file/d/1P4uWrNsV50j1jLhVpdCiuE5rvmjwczar/view?usp=drive_link

---

## 🛠️ Tecnologias Utilizadas

* Unity 2017.1.1f1
* C#
* Unity UI
* Git
* GitHub

---

## 👨‍💻 Autor

**Diego Guimarães**

---

## 📚 Referências

Projeto baseado no tutorial oficial da Unity:

https://unity3d.com/learn/tutorials/projects/survival-shooter-tutorial
