import React, { createContext, useState, useEffect, type ReactNode } from 'react';
import type { Usuario } from '../models/Usuario';

interface AuthContextData {
  usuario: Usuario | null;
  isAuthenticated: boolean;
  signIn: (token: string, user: Usuario) => void;
  signOut: () => void;
}

export const AuthContext = createContext<AuthContextData>({} as AuthContextData);

export const AuthProvider: React.FC<{ children: ReactNode }> = ({ children }) => {
  const [usuario, setUsuario] = useState<Usuario | null>(null);

  // Quando o app abrir, verifica se já tem alguém salvo no localStorage
  useEffect(() => {
    const storagedUser = localStorage.getItem('@App:user');
    const storagedToken = localStorage.getItem('@App:token');

    if (storagedUser && storagedToken) {
      setUsuario(JSON.parse(storagedUser));
    }
  }, []);

  const signIn = (token: string, user: Usuario) => {
    localStorage.setItem('@App:token', token);
    localStorage.setItem('@App:user', JSON.stringify(user));
    setUsuario(user);
  };

  const signOut = () => {
    localStorage.clear();
    setUsuario(null);
  };

  return (
    <AuthContext.Provider value={{ usuario, isAuthenticated: !!usuario, signIn, signOut }}>
      {children}
    </AuthContext.Provider>
  );
};