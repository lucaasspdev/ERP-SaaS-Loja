import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom'; // NOVO
import { Input } from '../../Components/forms/Input';
import { Button } from '../../Components/ui/Button';
import { authService } from '../../services/authService';
import { useAuth } from '../../hooks/useAuth'; // NOVO

export const LoginPage: React.FC = () => {
  const [email, setEmail] = useState('');
  const [senha, setSenha] = useState('');
  const [loading, setLoading] = useState(false);
  const [erro, setErro] = useState('');
  
  const { signIn } = useAuth(); // Puxando a função do nosso Contexto
  const navigate = useNavigate(); // Puxando o GPS das Rotas

  const handleLogin = async (e: React.FormEvent) => {
    e.preventDefault();
    setLoading(true);
    setErro('');

    try {
      const { token, user } = await authService.login(email, senha);
      
      signIn(token, user); // Salva no Contexto Global!
      navigate('/dashboard'); // Redireciona para o painel!
      
    } catch (error) {
      setErro('E-mail ou senha incorretos. Tente: admin@teste.com / 123456');
    } finally {
      setLoading(false);
    }
  };

  return (
    <div style={{ maxWidth: '400px', margin: '100px auto', padding: '20px', border: '1px solid #ddd', borderRadius: '8px', fontFamily: 'sans-serif' }}>
      <form onSubmit={handleLogin}>
        <h2 style={{ textAlign: 'center', marginBottom: '20px' }}>Acesso ao ERP</h2>
        
        {erro && <div style={{ color: 'red', marginBottom: '15px', textAlign: 'center' }}>{erro}</div>}

        <Input 
          label="E-mail" 
          id="email" 
          type="email" 
          value={email}
          onChange={(e) => setEmail(e.target.value)}
          placeholder="admin@teste.com"
          required
        />

        <Input 
          label="Senha" 
          id="senha" 
          type="password" 
          value={senha}
          onChange={(e) => setSenha(e.target.value)}
          placeholder="123456"
          required
        />

        <div style={{ marginTop: '20px' }}>
          <Button type="submit" isLoading={loading}>
            Entrar
          </Button>
        </div>
      </form>
    </div>
  );
};