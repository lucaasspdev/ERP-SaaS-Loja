import React from 'react';

export const DashboardPage: React.FC = () => {
  return (
    <div>
      <h1 style={{ marginTop: 0 }}>Visão Geral</h1>
      <p style={{ color: '#666' }}>Resumo das atividades do seu ERP.</p>
      
      {/* Aqui no futuro entrarão os gráficos e cartões de resumo! */}
      <div style={{ display: 'flex', gap: '20px', marginTop: '30px' }}>
        <div style={{ flex: 1, padding: '20px', backgroundColor: 'white', borderRadius: '8px', boxShadow: '0 2px 4px rgba(0,0,0,0.05)' }}>
          <h3>Vendas Hoje</h3>
          <p style={{ fontSize: '24px', fontWeight: 'bold', color: '#27ae60' }}>R$ 0,00</p>
        </div>
        <div style={{ flex: 1, padding: '20px', backgroundColor: 'white', borderRadius: '8px', boxShadow: '0 2px 4px rgba(0,0,0,0.05)' }}>
          <h3>Novos Clientes</h3>
          <p style={{ fontSize: '24px', fontWeight: 'bold', color: '#2980b9' }}>0</p>
        </div>
      </div>
    </div>
  );
};