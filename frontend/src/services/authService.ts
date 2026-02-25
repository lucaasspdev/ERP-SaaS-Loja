import type { Usuario } from '../models/Usuario';

interface LoginResponse {
  token: string;
  user: Usuario;
}

export const authService = {
  login: async (email: string, senha: string): Promise<LoginResponse> => {
    // Simulando o tempo de resposta de uma API real (2 segundos)
    await new Promise(resolve => setTimeout(resolve, 2000));

    // Simulando a verificação no banco de dados
    if (email === 'admin@teste.com' && senha === '123456') {
      return {
        token: 'eyJhGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.fake.token',
        user: { id: '1', nome: 'Administrador', email },
      };
    }

    throw new Error('Credenciais inválidas');
  }
};