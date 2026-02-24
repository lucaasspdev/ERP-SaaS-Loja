import React, { type InputHTMLAttributes } from 'react';

interface InputProps extends InputHTMLAttributes<HTMLInputElement> {
  label: string;
}

export const Input: React.FC<InputProps> = ({ label, id, ...props }) => {
  return (
    <div style={{ display: 'flex', flexDirection: 'column', marginBottom: '15px' }}>
      <label htmlFor={id} style={{ marginBottom: '5px', fontWeight: 'bold' }}>
        {label}
      </label>
      <input 
        id={id} 
        style={{ padding: '10px', borderRadius: '4px', border: '1px solid #ccc' }}
        {...props} 
      />
    </div>
  );
};