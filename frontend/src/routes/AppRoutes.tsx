import React from 'react';
import { BrowserRouter, Routes, Route, Navigate } from 'react-router-dom';
import { LoginPage } from '../pages/Login/LoginPage';
import { DashboardPage } from '../pages/Dashboard/DashboardPage';
import { PrivateRoute } from './PrivateRoute';
import { MainLayout } from '../Components/layout/MainLayout'; // NOVO IMPORT

export const AppRoutes: React.FC = () => {
  return (
    <BrowserRouter>
      <Routes>
        {/* Rota Pública (Tela cheia, sem o Layout lateral) */}
        <Route path="/login" element={<LoginPage />} />

        {/* Rotas Protegidas */}
        <Route element={<PrivateRoute />}>
          
          {/* O MainLayout envelopa as páginas internas */}
          <Route element={<MainLayout />}>
            <Route path="/dashboard" element={<DashboardPage />} />
            {/* Exemplo de onde entrarão as próximas: */}
            {/* <Route path="/clientes" element={<ClienteListPage />} /> */}
          </Route>

        </Route>

        {/* Rota fallback (caiu em URL inexistente, vai pro dashboard) */}
        <Route path="*" element={<Navigate to="/dashboard" replace />} />
      </Routes>
    </BrowserRouter>
  );
};