import React from 'react';
import { Navigate, Outlet } from 'react-router-dom';
import { useAuth } from '../hooks/useAuth';

export const PrivateRoute: React.FC = () => {
  const { isAuthenticated } = useAuth();

  // Se estiver logado, renderiza a tela filha (Outlet). Se não, redireciona.
  return isAuthenticated ? <Outlet /> : <Navigate to="/login" replace />;
};