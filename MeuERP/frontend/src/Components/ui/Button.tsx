import React, { type ButtonHTMLAttributes } from 'react';

interface ButtonProps extends ButtonHTMLAttributes<HTMLButtonElement> {
  isLoading?: boolean;
}

export const Button: React.FC<ButtonProps> = ({ children, isLoading, ...props }) => {
  return (
    <button 
      disabled={isLoading} 
      style={{
        padding: '10px 20px',
        backgroundColor: isLoading ? '#ccc' : '#007bff',
        color: '#fff',
        border: 'none',
        borderRadius: '4px',
        cursor: isLoading ? 'not-allowed' : 'pointer',
        width: '100%',
        fontWeight: 'bold'
      }}
      {...props}
    >
      {isLoading ? 'Carregando...' : children}
    </button>
  );
};