import React from 'react';
import { Outlet, useNavigate } from 'react-router-dom';
import { useAuth } from '../../hooks/useAuth';

export const MainLayout: React.FC = () => {
  const { usuario, signOut } = useAuth();
  const navigate = useNavigate();

  const handleLogout = () => {
    signOut();
    navigate('/login');
  };

  return (
    <div style={{ display: 'flex', height: '100vh', fontFamily: 'sans-serif' }}>
      
      {/* BARRA LATERAL (Sidebar) */}
      <aside style={{ width: '250px', backgroundColor: '#2c3e50', color: '#ecf0f1', display: 'flex', flexDirection: 'column' }}>
        <div style={{ padding: '20px', fontSize: '24px', fontWeight: 'bold', borderBottom: '1px solid #34495e', textAlign: 'center' }}>
          ERP SaaS
        </div>
        
        <nav style={{ flex: 1, padding: '20px 0' }}>
          <ul style={{ listStyle: 'none', padding: 0, margin: 0 }}>
            {/* Aqui no futuro transformaremos em links reais com o React Router */}
            <li style={{ padding: '15px 20px', cursor: 'pointer', borderBottom: '1px solid #34495e' }}>📊 Dashboard</li>
            <li style={{ padding: '15px 20px', cursor: 'pointer', borderBottom: '1px solid #34495e' }}>👥 Clientes</li>
            <li style={{ padding: '15px 20px', cursor: 'pointer', borderBottom: '1px solid #34495e' }}>📦 Produtos</li>
            <li style={{ padding: '15px 20px', cursor: 'pointer', borderBottom: '1px solid #34495e' }}>🛒 PDV</li>
          </ul>
        </nav>
      </aside>

      {/* ÁREA DIREITA (Header + Conteúdo Principal) */}
      <div style={{ flex: 1, display: 'flex', flexDirection: 'column', backgroundColor: '#f4f6f8' }}>
        
        {/* CABEÇALHO (Header) */}
        <header style={{ height: '60px', backgroundColor: '#ffffff', borderBottom: '1px solid #e0e0e0', display: 'flex', alignItems: 'center', justifyContent: 'flex-end', padding: '0 30px', boxShadow: '0 2px 4px rgba(0,0,0,0.05)' }}>
          <div style={{ display: 'flex', alignItems: 'center', gap: '20px' }}>
            <span>Olá, <strong>{usuario?.nome}</strong></span>
            <button 
              onClick={handleLogout}
              style={{ padding: '8px 15px', backgroundColor: '#e74c3c', color: 'white', border: 'none', borderRadius: '4px', cursor: 'pointer', fontWeight: 'bold' }}
            >
              Sair
            </button>
          </div>
        </header>

        {/* ÁREA DE CONTEÚDO DINÂMICO (Onde as páginas vão aparecer) */}
        <main style={{ flex: 1, padding: '30px', overflowY: 'auto' }}>
          {/* O componente <Outlet /> é o "buraco" onde o React Router vai injetar as telas */}
          <Outlet /> 
        </main>
      </div>
    </div>
  );
};